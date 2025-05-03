using ClosedXML.Excel;
using SVPresentation.Utilidades;
using SVPresentation.ViewModels;
using SVServices.Interfaces;
using System.Data;
using System.Diagnostics;

namespace SVPresentation.Formularios
{
    public partial class FrmReporteVenta : Form
    {
        private readonly IVentaService _ventaService;
        private readonly INegocioService _negocioService;
        public FrmReporteVenta(IVentaService ventaService, INegocioService negocioService)
        {
            InitializeComponent();
            _ventaService = ventaService;
            _negocioService = negocioService;
        }

        private void FrmReporteVenta_Load(object sender, EventArgs e)
        {
            dgvReporte.ImplementarConfiguracion();
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            var lista = await _ventaService.Reporte(
                dtpFechaInicio.Value.ToString("dd/MM/yyyy"),
                dtpFechaFin.Value.ToString("dd/MM/yyyy")
            );

            var listaVN = lista.Select(item => new ReporteVentaVM
            {
                NumeroVenta = item.RefVenta!.NumeroVenta,
                NombreUsuario = item.RefVenta.UsuarioRegistro!.NombreUsuario,
                FechaRegistro = item.RefVenta.FechaRegistro,
                Producto = item.RefProducto!.Descripcion,
                PrecioCompra = item.RefProducto.PrecioCompra,
                PrecioVenta = item.PrecioVenta,
                Cantidad = item.Cantidad,
                PrecioTotal = item.PrecioTotal
            }).ToList();

            dgvReporte.DataSource = listaVN;
            //dgvReporte.Columns["Producto"].Width = 200;
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            if (dgvReporte.Rows.Count == 0)
            {
                MessageBox.Show("No existen resultados");
                return;
            }

            DataTable tabla = new DataTable();
            List<ReporteVentaVM> detalle = (List<ReporteVentaVM>)dgvReporte.DataSource;

            foreach (DataGridViewColumn columna in dgvReporte.Columns)
                tabla.Columns.Add(columna.HeaderText, typeof(string));

            foreach (var item in detalle)
            {
                tabla.Rows.Add(
                    item.NumeroVenta,
                    item.NombreUsuario,
                    item.FechaRegistro,
                    item.Producto,
                    item.PrecioCompra,
                    item.PrecioVenta,
                    item.Cantidad,
                    item.PrecioTotal
                );
            }

            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                //saveFile.FileName = $"ReporteVenta_{DateTime.Now:ddMMyyyyHHmmss}.xlsx";
                saveFile.FileName = $"ReporteVenta_{DateTime.Now.ToString("ddMMyyyyHHmmss")}.xlsx";
                saveFile.Filter = "Excel files|*.xlsx";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(tabla, "Reporte");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(saveFile.FileName);
                        MessageBox.Show("Reporte generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
        }

        private async void BtnReporteCaja_Click(object sender, EventArgs e)
        {
            var lista = await _ventaService.Reporte(
                dtpFechaInicio.Value.ToString("dd/MM/yyyy"),
                dtpFechaFin.Value.ToString("dd/MM/yyyy")
            );

            if (lista.Count == 0)
            {
                MessageBox.Show("No existe informacion");
                return;
            }

            var fecIni = dtpFechaInicio.Value.ToString("dd/MM/yyyy");
            var fecFin = dtpFechaFin.Value.ToString("dd/MM/yyyy");

            DialogResult result = MessageBox.Show(
            "¿Desea guardar y visualizar el documento?",
            "Reporte Generado",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information
            );

            if (result == DialogResult.Yes)
            {
                var oNegocio = await _negocioService.Obtener();
                var arrayPDF = Util.GenerarPDFDetalleVenta(oNegocio, fecIni, fecFin, lista);

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Guardar PDF";
                    saveFileDialog.DefaultExt = "pdf";
                    saveFileDialog.AddExtension = true;
                    saveFileDialog.FileName = $"ReporteCaja_{DateTime.Now:ddMMyyyyHHmmss}";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        await File.WriteAllBytesAsync(saveFileDialog.FileName, arrayPDF);

                        Process.Start(new ProcessStartInfo
                        {
                            FileName = saveFileDialog.FileName,
                            UseShellExecute = true
                        });
                    }
                }

            }
        }
    }
}
