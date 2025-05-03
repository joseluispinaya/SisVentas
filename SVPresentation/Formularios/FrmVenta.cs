using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using SVPresentation.Utilidades;
using SVPresentation.ViewModels;
using SVServices.Interfaces;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;


namespace SVPresentation.Formularios
{
    public partial class FrmVenta : Form
    {
        private readonly IProductoService _productoService;
        private readonly IVentaService _ventaService;
        private readonly INegocioService _negocioService;
        private readonly IServiceProvider _serviceProvider;
        private BindingList<DetalleVentaVM> _detalleVenta = new BindingList<DetalleVentaVM>();

        public FrmVenta(IProductoService productoService, IVentaService ventaService, INegocioService negocioService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _productoService = productoService;
            _ventaService = ventaService;
            _negocioService = negocioService;
            _serviceProvider = serviceProvider;
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            dgvDetalleVenta.ImplementarConfiguracion("Eliminar");
            dgvDetalleVenta.DataSource = _detalleVenta;
            dgvDetalleVenta.Columns["IdProducto"].Visible = false;
            dgvDetalleVenta.Columns["CantidadValor"].Visible = false;
            dgvDetalleVenta.Columns["Producto"].FillWeight = 350;
            dgvDetalleVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async Task AgregarProducto(string codigoProducto)
        {
            var producto = await _productoService.Obtener(codigoProducto);
            if (producto.IdProducto == 0)
            {
                txbCodigoProducto.BackColor = Color.FromArgb(255, 227, 227);
                return;
            }

            txbCodigoProducto.BackColor = SystemColors.Window;

            StringBuilder sb = new StringBuilder();
            //sb.AppendLine(producto.Nombre);
            sb.AppendLine(producto.Descripcion);
            sb.AppendLine("Categoría: " + producto.RefCategoria!.Nombre);
            sb.AppendLine("Precio: " + producto.PrecioVenta.ToString("0.00"));
            sb.AppendLine("");
            sb.AppendLine("Ingresa la cantidad (" + producto.RefCategoria.RefMedida!.Equivalente + "):");
            string cantidadString = Interaction.InputBox(sb.ToString(), "Producto", "1");

            if (string.IsNullOrEmpty(cantidadString)) return;

            int cantidad;

            if (!int.TryParse(cantidadString, out cantidad))
            {
                MensajeError("El valor ingresado no es un numero");
                return;
            }

            if (cantidad > producto.Cantidad)
            {
                MensajeError("La cantidad ingresada no puede exceder al stock");
                return;
            }

            var encontrado = _detalleVenta.FirstOrDefault(x => x.IdProducto == producto.IdProducto);

            if (encontrado == null)
            {
                decimal total = (cantidad * producto.PrecioVenta) / producto.RefCategoria.RefMedida.Valor;

                _detalleVenta.Add(new DetalleVentaVM
                {
                    IdProducto = producto.IdProducto,
                    //Producto = producto.Nombre,
                    Producto = producto.Descripcion,
                    Precio = producto.PrecioVenta,
                    CantidadValor = cantidad,
                    CantidadTexto = string.Concat(cantidad, " ", producto.RefCategoria.RefMedida.Equivalente),
                    Total = Convert.ToDecimal(total.ToString("0.00"))
                });
            }
            else
            {
                int index = _detalleVenta.IndexOf(encontrado);
                int cantidadTotal = encontrado.CantidadValor + cantidad;
                decimal total = (cantidadTotal * producto.PrecioVenta) / producto.RefCategoria.RefMedida.Valor;

                //encontrado.CantidadValor += cantidad;
                encontrado.CantidadValor = cantidadTotal;
                encontrado.CantidadTexto = string.Concat(cantidadTotal + " " + producto.RefCategoria.RefMedida.Equivalente);
                encontrado.Total = Convert.ToDecimal(total.ToString("0.00"));

                _detalleVenta[index] = encontrado;
            }

            decimal Total = _detalleVenta.Sum(x => x.Total);
            int cantTot = _detalleVenta.Sum(x => x.CantidadValor);

            lblTotal.Text = Total.ToString("0.00");
            txbCantidadTotal.Text = cantTot.ToString();
            txbCodigoProducto.Text = "";
        }

        private async void txbCodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                await AgregarProducto(txbCodigoProducto.Text.Trim());
            }
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            var _formBuscarProducto = _serviceProvider.GetRequiredService<FrmBuscarProducto>();
            var resultado = _formBuscarProducto.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                var productoSeleccionado = _formBuscarProducto._productoSeleccionado;
                txbCodigoProducto.Text = productoSeleccionado.Codigo;
                await AgregarProducto(productoSeleccionado.Codigo);

            }
        }

        private void dgvDetalleVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalleVenta.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var filaSeleccionada = (DetalleVentaVM)dgvDetalleVenta.CurrentRow.DataBoundItem;
                var index = _detalleVenta.IndexOf(filaSeleccionada);
                _detalleVenta.RemoveAt(index);

                decimal Total = _detalleVenta.Sum(x => x.Total);
                int cantTot = _detalleVenta.Sum(x => x.CantidadValor);

                lblTotal.Text = Total.ToString("0.00");
                txbCantidadTotal.Text = cantTot.ToString();

            }
        }

        private async void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (_detalleVenta.Count == 0)
            {
                MensajeError("No hay productos para registrar");
                return;
            }

            if (string.IsNullOrWhiteSpace(txbNombreCliente.Text))
            {
                MensajeError("Debe ingresar Nombre Cliente.");
                txbNombreCliente.Focus();
                return;
            }

            decimal tempTotal = _detalleVenta.Sum(x => x.Total);
            int CantTot = _detalleVenta.Sum(x => x.CantidadValor);

            var precioTotal = Convert.ToDecimal(tempTotal.ToString("0.00"));

            XElement venta = new XElement("Venta",
                new XElement("IdUsuarioRegistro", UsuarioSesion.IdUsuario),
                new XElement("NombreCliente", txbNombreCliente.Text.Trim()),
                new XElement("PrecioTotal", precioTotal),
                new XElement("CantidadTotal", CantTot)
            );

            XElement detalleVenta = new XElement("DetalleVenta");

            foreach (DetalleVentaVM item in _detalleVenta)
            {
                detalleVenta.Add(new XElement("Item",

                    new XElement("IdProducto", item.IdProducto),
                    new XElement("Cantidad", item.CantidadValor),
                    new XElement("PrecioVenta", item.Precio),
                    new XElement("PrecioTotal", item.Total)
                    )

                );
            }
            venta.Add(detalleVenta);

            var numeroVenta = await _ventaService.Registrar(venta.ToString());

            if (numeroVenta == "")
            {
                MensajeError("No se pudo generar la venta");
                return;
            }

            txbCodigoProducto.Text = "";
            txbNombreCliente.Text = "";
            _detalleVenta.Clear();
            lblTotal.Text = "0";
            txbCantidadTotal.Text = "";
            txbCodigoProducto.Select();

            DialogResult result = MessageBox.Show(
                $"Numero de venta: {numeroVenta}, ¿Desea guardar y visualizar el documento?",
                "Registrado correctamente",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
                );

            if (result == DialogResult.Yes)
            {
                var oNegocio = await _negocioService.Obtener();
                var oVenta = await _ventaService.Obtener(numeroVenta);
                var oDetalleVenta = await _ventaService.ObtenerDetalle(numeroVenta);
                oVenta.RefDetalleVenta = oDetalleVenta;

                var arrayPDF = Util.GenerarPDFVenta(oNegocio, oVenta);

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Guardar PDF";
                    saveFileDialog.DefaultExt = "pdf";
                    saveFileDialog.AddExtension = true;
                    saveFileDialog.FileName = $"{numeroVenta}";

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
