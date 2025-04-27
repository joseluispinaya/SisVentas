using SVPresentation.Utilidades;
using SVPresentation.Utilidades.Objetos;
using SVPresentation.ViewModels;
using SVRepository.Entities;
using SVServices.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVPresentation.Formularios
{
    public partial class FrmProducto : Form
    {
        private readonly IProductoService _productoService;
        private readonly ICategoriaService _categoriaService;
        public FrmProducto(IProductoService productoService, ICategoriaService categoriaService)
        {
            InitializeComponent();
            _productoService = productoService;
            _categoriaService = categoriaService;
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MostrarTab(string tabName)
        {
            var TabsMenu = new TabPage[] { tabLista, tabNuevo, tabEditar };

            foreach (var tab in TabsMenu)
            {
                if (tab.Name != tabName)
                {
                    tab.Parent = null;
                }
                else
                {
                    tab.Parent = tabControlMain;
                }
            }
        }

        private async Task MostrarProductos(string buscar = "")
        {
            var listaproductos = await _productoService.Lista(buscar);

            var listaVM = listaproductos.Select(item => new ProductoVM
            {
                IdProducto = item.IdProducto,
                Codigo = item.Codigo,
                Nombre = item.Nombre,
                Descripcion = item.Descripcion,
                IdCategoria = item.RefCategoria!.IdCategoria,
                Categoria = item.RefCategoria.Nombre,
                PrecioCompra = item.PrecioCompra.ToString("0.00"),
                PrecioVenta = item.PrecioVenta.ToString("0.00"),
                Cantidad = item.Cantidad,
                Activo = item.Activo,
                Habilitado = item.Activo == 1 ? "Si" : "No"
            }).ToList();

            dgvProductos.DataSource = listaVM;

            dgvProductos.Columns["IdProducto"].Visible = false;
            dgvProductos.Columns["IdCategoria"].Visible = false;
            dgvProductos.Columns["Nombre"].Visible = false;
            dgvProductos.Columns["Activo"].Visible = false;
            dgvProductos.Columns["Descripcion"].Width = 200;
        }

        private async void FrmProducto_Load(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
            dgvProductos.ImplementarConfiguracion("Editar");
            //dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txbPrecioCompNuevo.ValidarNumero();
            txbPrecioComEditar.ValidarNumero();
            txbPrecioVentaNuevo.ValidarNumero();
            txbPrecioVentaEditar.ValidarNumero();
            await MostrarProductos();

            OpcionCombo[] itemsHabilitado =
            [
                new OpcionCombo{Texto = "Si", Valor = 1},
                new OpcionCombo{Texto = "No", Valor = 0}
            ];

            var listaCategoria = await _categoriaService.Lista();
            var items = listaCategoria.Where(item => item.Activo == 1).Select(item => new OpcionCombo
            {
                Texto = item.Nombre,
                Valor = item.IdCategoria
            }).ToArray();

            cbbCategoriaNuevo.InsertarItems(items);
            cbbCategoriaEditar.InsertarItems(items);

            cbbHabilitado.InsertarItems(itemsHabilitado);
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await MostrarProductos(txbBuscar.Text);
        }

        private void btnNuevoLista_Click(object sender, EventArgs e)
        {
            MostrarTab(tabNuevo.Name);
            cbbCategoriaNuevo.SelectedIndex = 0;
            txbCodigoNuevo.Text = "";
            txbNombreNuevop.Text = "";
            txbDescripcionNuevo.Text = "";
            txbPrecioCompNuevo.Text = "";
            txbPrecioVentaNuevo.Text = "";
            txbCantidadNuevo.Value = 0;
            cbbCategoriaNuevo.Select();
        }

        private void btnVolverNuevo_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private bool CamposValidos()
        {
            var culture = new CultureInfo("es-ES");


            if (string.IsNullOrWhiteSpace(txbCodigoNuevo.Text))
            {
                MensajeError("Debe ingresar el código.");
                txbCodigoNuevo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbNombreNuevop.Text))
            {
                MensajeError("Debe ingresar el nombre.");
                txbNombreNuevop.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbDescripcionNuevo.Text))
            {
                MensajeError("Debe ingresar la descripción.");
                txbDescripcionNuevo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbPrecioCompNuevo.Text))
            {
                MensajeError("Debe ingresar el precio de compra.");
                txbPrecioCompNuevo.Focus();
                return false;
            }

            if (!decimal.TryParse(txbPrecioCompNuevo.Text,
                          NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands,
                          culture,
                          out _))
            {
                MensajeError("Formato incorrecto de precio de Compra.");
                txbPrecioCompNuevo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbPrecioVentaNuevo.Text))
            {
                MensajeError("Debe ingresar el precio de venta.");
                txbPrecioVentaNuevo.Focus();
                return false;
            }


            if (!decimal.TryParse(txbPrecioVentaNuevo.Text,
                          NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands,
                          culture,
                          out _))
            {
                MensajeError("Formato incorrecto de precio de venta.");
                txbPrecioVentaNuevo.Focus();
                return false;
            }

            if (txbCantidadNuevo.Value == 0)
            {
                MensajeError("La cantidad debe ser mayor a cero.");
                txbCantidadNuevo.Focus();
                return false;
            }

            // Si todo está bien:
            return true;
        }

        private async void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            if (!CamposValidos())
            {
                return;
            }

            var culture = new CultureInfo("es-ES");
            decimal precioCompra = decimal.Parse(txbPrecioCompNuevo.Text,
                                          NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands,
                                          culture);

            decimal precioVenta = decimal.Parse(txbPrecioVentaNuevo.Text,
                                          NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands,
                                          culture);


            var objeto = new Producto
            {
                RefCategoria = new Categoria { IdCategoria = ((OpcionCombo)cbbCategoriaNuevo.SelectedItem!).Valor },
                Codigo = txbCodigoNuevo.Text.Trim(),
                Nombre = txbNombreNuevop.Text.Trim(),
                Descripcion = txbDescripcionNuevo.Text.Trim(),
                PrecioCompra = precioCompra,
                PrecioVenta = precioVenta,
                Cantidad = Convert.ToInt32(txbCantidadNuevo.Value)
            };

            var respuesta = await _productoService.Crear(objeto);

            if (respuesta != "")
            {
                MensajeError(respuesta);
            }
            else
            {
                await MostrarProductos();
                MostrarTab(tabLista.Name);
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var productoSeleccionada = (ProductoVM)dgvProductos.CurrentRow.DataBoundItem;

                cbbCategoriaEditar.EstablecerValor(productoSeleccionada.IdCategoria);
                txbCodigoEditar.Text = productoSeleccionada.Codigo;
                txbNombreEditar.Text = productoSeleccionada.Nombre;
                txbDescripcionEditar.Text = productoSeleccionada.Descripcion;
                txbPrecioComEditar.Text = productoSeleccionada.PrecioCompra;
                txbPrecioVentaEditar.Text = productoSeleccionada.PrecioVenta;
                txbCantidadEditar.Value = productoSeleccionada.Cantidad;
                cbbHabilitado.EstablecerValor(productoSeleccionada.Activo);

                MostrarTab(tabEditar.Name);
                cbbCategoriaEditar.Select();
            }
        }

        private void btnVolverEditar_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private bool CamposValidosEditar()
        {
            var culture = new CultureInfo("es-ES");


            if (string.IsNullOrWhiteSpace(txbCodigoEditar.Text))
            {
                MensajeError("Debe ingresar el código.");
                txbCodigoEditar.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbNombreEditar.Text))
            {
                MensajeError("Debe ingresar el nombre.");
                txbNombreEditar.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbDescripcionEditar.Text))
            {
                MensajeError("Debe ingresar la descripción.");
                txbDescripcionEditar.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbPrecioComEditar.Text))
            {
                MensajeError("Debe ingresar el precio de compra.");
                txbPrecioComEditar.Focus();
                return false;
            }

            if (!decimal.TryParse(txbPrecioComEditar.Text,
                          NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands,
                          culture,
                          out _))
            {
                MensajeError("Formato incorrecto de precio de Compra.");
                txbPrecioComEditar.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbPrecioVentaEditar.Text))
            {
                MensajeError("Debe ingresar el precio de venta.");
                txbPrecioVentaEditar.Focus();
                return false;
            }


            if (!decimal.TryParse(txbPrecioVentaEditar.Text,
                          NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands,
                          culture,
                          out _))
            {
                MensajeError("Formato incorrecto de precio de venta.");
                txbPrecioVentaEditar.Focus();
                return false;
            }

            if (txbCantidadEditar.Value == 0)
            {
                MensajeError("La cantidad debe ser mayor a cero.");
                txbCantidadEditar.Focus();
                return false;
            }

            // Si todo está bien:
            return true;
        }

        private async void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            if (!CamposValidosEditar())
            {
                return;
            }

            var productoSeleccionada = (ProductoVM)dgvProductos.CurrentRow.DataBoundItem;
            var culture = new CultureInfo("es-ES");
            decimal precioCompra = decimal.Parse(txbPrecioComEditar.Text,
                                          NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands,
                                          culture);

            decimal precioVenta = decimal.Parse(txbPrecioVentaEditar.Text,
                                          NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands,
                                          culture);

            var objeto = new Producto
            {
                IdProducto = productoSeleccionada.IdProducto,
                RefCategoria = new Categoria { IdCategoria = ((OpcionCombo)cbbCategoriaEditar.SelectedItem!).Valor },
                Codigo = txbCodigoEditar.Text.Trim(),
                Nombre = txbNombreEditar.Text.Trim(),
                Descripcion = txbDescripcionEditar.Text.Trim(),
                PrecioCompra = precioCompra,
                PrecioVenta = precioVenta,
                Cantidad = Convert.ToInt32(txbCantidadEditar.Value),
                Activo = ((OpcionCombo)cbbHabilitado.SelectedItem!).Valor
            };

            var respuesta = await _productoService.Editar(objeto);

            if (respuesta != "")
            {
                MensajeError(respuesta);
            }
            else
            {
                await MostrarProductos();
                MostrarTab(tabLista.Name);
            }
        }
    }
}
