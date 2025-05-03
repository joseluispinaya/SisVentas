using SVPresentation.Utilidades;
using SVPresentation.ViewModels;
using SVServices.Interfaces;
using System.Diagnostics;

namespace SVPresentation.Formularios
{
    public partial class FrmDetalleVenta : Form
    {
        private readonly IVentaService _ventaService;
        private readonly INegocioService _negocioService;
        public string _numeroVenta { get; set; } = null!;
        public FrmDetalleVenta(IVentaService ventaService, INegocioService negocioService)
        {
            InitializeComponent();
            _ventaService = ventaService;
            _negocioService = negocioService;
        }

        private async void FrmDetalleVenta_Load(object sender, EventArgs e)
        {
            dgvDetalle.ImplementarConfiguracion();
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var detalleVenta = await _ventaService.ObtenerDetalle(_numeroVenta);

            var listaVM =
                detalleVenta.Select(item => new DetalleVentaVM
                {
                    Producto = item.RefProducto!.Descripcion,
                    Precio = item.PrecioVenta,
                    CantidadTexto = string.Concat(item.Cantidad, " ", item.RefProducto!.RefCategoria!.RefMedida!.Equivalente),
                    Total = item.PrecioTotal
                }).ToList();

            lblNroVenta.Text = _numeroVenta;

            dgvDetalle.DataSource = listaVM;
            dgvDetalle.Columns["IdProducto"].Visible = false;
            dgvDetalle.Columns["CantidadValor"].Visible = false;
        }

        private async void BtnVerPdf_Click(object sender, EventArgs e)
        {
            var oNegocio = await _negocioService.Obtener();
            var oVenta = await _ventaService.Obtener(_numeroVenta);
            var oDetalleVenta = await _ventaService.ObtenerDetalle(_numeroVenta);
            oVenta.RefDetalleVenta = oDetalleVenta;

            var arrayPDF = Util.GenerarPDFVenta(oNegocio, oVenta);

            using (SaveFileDialog saveFileDialog = new())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar PDF";
                saveFileDialog.DefaultExt = "pdf";
                saveFileDialog.AddExtension = true;
                saveFileDialog.FileName = $"{_numeroVenta}";

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
