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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVPresentation.Formularios
{
    public partial class FrmUsuario : Form
    {
        private readonly IRolService _rolService;
        private readonly IUsuarioService _usuarioService;
        public FrmUsuario(IRolService rolService, IUsuarioService usuarioService)
        {
            InitializeComponent();
            _rolService = rolService;
            _usuarioService = usuarioService;
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

        private async Task MostrarUsuarios(string buscar = "")
        {
            var listaUsuarios = await _usuarioService.Lista(buscar);

            var listaVM = listaUsuarios.Select(item => new UsuarioVM
            {
                IdUsuario = item.IdUsuario,
                IdRol = item.RefRol!.IdRol,
                Rol = item.RefRol.Nombre!,
                NombreCompleto = item.NombreCompleto,
                Correo = item.Correo,
                NombreUsuario = item.NombreUsuario,
                Clave = item.Clave,
                Activo = item.Activo,
                Habilitado = item.Activo == 1 ? "Si" : "No"
            }).ToList();

            dgvUsuarios.DataSource = listaVM;

            dgvUsuarios.Columns["IdUsuario"].Visible = false;
            dgvUsuarios.Columns["IdRol"].Visible = false;
            dgvUsuarios.Columns["Clave"].Visible = false;
            dgvUsuarios.Columns["Activo"].Visible = false;
        }

        private async void FrmUsuario_Load(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
            dgvUsuarios.ImplementarConfiguracion("Editar");
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            await MostrarUsuarios();

            OpcionCombo[] itemsHabilitado =
            [
                new OpcionCombo{Texto = "Si", Valor = 1},
                new OpcionCombo{Texto = "No", Valor = 0}
            ];

            var listaRol = await _rolService.Lista();
            var items = listaRol.Select(item => new OpcionCombo
            {
                Texto = item.Nombre,
                Valor = item.IdRol
            }).ToArray();

            cbbRolNuevo.InsertarItems(items);
            cbbRolEditar.InsertarItems(items);

            cbbHabilitado.InsertarItems(itemsHabilitado);
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            await MostrarUsuarios(txbBuscar.Text);
        }

        private void BtnNuevoLista_Click(object sender, EventArgs e)
        {
            cbbRolNuevo.SelectedIndex = 0;
            txbNombreCompNuevo.Text = "";
            txbCorreoNuevo.Text = "";
            txbNombreUseNuevo.Text = "";
            txbClaveNuevo.Text = "";
            MostrarTab(tabNuevo.Name);
            cbbRolNuevo.Select();
        }

        private void BtnVolverNuevo_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private bool CamposValidos()
        {

            if (string.IsNullOrWhiteSpace(txbNombreCompNuevo.Text))
            {
                MensajeError("Debe ingresar el Nombre.");
                txbNombreCompNuevo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbCorreoNuevo.Text))
            {
                MensajeError("Debe ingresar el correo.");
                txbCorreoNuevo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbNombreUseNuevo.Text))
            {
                MensajeError("Debe ingresar Su usuario.");
                txbNombreUseNuevo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbClaveNuevo.Text))
            {
                MensajeError("Debe ingresar una clave.");
                txbClaveNuevo.Focus();
                return false;
            }

            // Si todo está bien:
            return true;
        }

        private async void BtnGuardarNuevo_Click(object sender, EventArgs e)
        {
            if (!CamposValidos())
            {
                return;
            }

            var objeto = new Usuario
            {
                RefRol = new Rol { IdRol = ((OpcionCombo)cbbRolNuevo.SelectedItem!).Valor },
                NombreCompleto = txbNombreCompNuevo.Text.Trim(),
                Correo = txbCorreoNuevo.Text.Trim(),
                NombreUsuario = txbNombreUseNuevo.Text.Trim(),
                Clave = txbClaveNuevo.Text.Trim()
            };
            var respuesta = await _usuarioService.Crear(objeto);

            if (respuesta != "")
            {
                MensajeError(respuesta);
            }
            else
            {
                await MostrarUsuarios();
                MostrarTab(tabLista.Name);
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var usuarioSeleccionada = (UsuarioVM)dgvUsuarios.CurrentRow.DataBoundItem;

                cbbRolEditar.EstablecerValor(usuarioSeleccionada.IdRol);
                txbNombreComEditar.Text = usuarioSeleccionada.NombreCompleto;
                txbCorreoEditar.Text = usuarioSeleccionada.Correo;
                txbNombreUserEditar.Text = usuarioSeleccionada.NombreUsuario;
                txbClaveEditar.Text = usuarioSeleccionada.Clave;
                cbbHabilitado.EstablecerValor(usuarioSeleccionada.Activo);

                MostrarTab(tabEditar.Name);
                cbbRolEditar.Select();
            }
        }

        private void BtnVolverEditar_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private bool CamposValidosEditar()
        {

            if (string.IsNullOrWhiteSpace(txbNombreComEditar.Text))
            {
                MensajeError("Debe ingresar el Nombre.");
                txbNombreComEditar.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbCorreoEditar.Text))
            {
                MensajeError("Debe ingresar el correo.");
                txbCorreoEditar.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbNombreUserEditar.Text))
            {
                MensajeError("Debe ingresar Su usuario.");
                txbNombreUserEditar.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbClaveEditar.Text))
            {
                MensajeError("Debe ingresar una clave.");
                txbClaveEditar.Focus();
                return false;
            }

            // Si todo está bien:
            return true;
        }

        private async void BtnGuardarEditar_Click(object sender, EventArgs e)
        {
            if (!CamposValidosEditar())
            {
                return;
            }

            var usuarioSeleccionada = (UsuarioVM)dgvUsuarios.CurrentRow.DataBoundItem;
            var objeto = new Usuario
            {
                IdUsuario = usuarioSeleccionada.IdUsuario,
                RefRol = new Rol { IdRol = ((OpcionCombo)cbbRolEditar.SelectedItem!).Valor },
                NombreCompleto = txbNombreComEditar.Text.Trim(),
                Correo = txbCorreoEditar.Text.Trim(),
                NombreUsuario = txbNombreUserEditar.Text.Trim(),
                Clave = txbClaveEditar.Text.Trim(),
                Activo = ((OpcionCombo)cbbHabilitado.SelectedItem!).Valor
            };

            var respuesta = await _usuarioService.Editar(objeto);

            if (respuesta != "")
            {
                MensajeError(respuesta);
            }
            else
            {
                await MostrarUsuarios();
                MostrarTab(tabLista.Name);
            }

        }
    }
}
