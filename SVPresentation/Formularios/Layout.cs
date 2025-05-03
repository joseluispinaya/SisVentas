using Microsoft.Extensions.DependencyInjection;
using SVPresentation.Utilidades;
using SVServices.Interfaces;

namespace SVPresentation.Formularios
{
    public partial class Layout : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IMenuRolService _menuRolService;

        public Layout(IServiceProvider serviceProvider, IMenuRolService menuRolService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _menuRolService = menuRolService;
        }

        private void MostrarFormulario<TForm>() where TForm : Form
        {
            if (panelMain.Controls.Count > 0) panelMain.Controls[0].Dispose();

            var newForm = _serviceProvider.GetRequiredService<TForm>();

            newForm.TopLevel = false;
            newForm.TopMost = false;
            panelMain.Controls.Add(newForm);
            newForm.Show();
        }

        private async void Layout_Load(object sender, EventArgs e)
        {
            msMenu.Renderer = new CustomToolStripRenderer();

            lblUsuario.Text = $"Usuario: {UsuarioSesion.NombreUsuario}";
            lblRol.Text = $"Rol: {UsuarioSesion.Rol}";
            lblMain.Text = $"Bienvenido: \n{UsuarioSesion.NombreCompleto}";

            var listaPrincipal = await _menuRolService.Lista(UsuarioSesion.IdRol);

            var menusPadre = listaPrincipal.Where(x => x.IdMenuPadre == 0).ToList();
            var menusHijo = listaPrincipal.Where(x => x.IdMenuPadre != 0).ToList();

            var menus = new ToolStripMenuItem[] { mnVentas, mnInventario, mnReportes, mnUsuarios, mnConfiguracion };
            var submenus = new ToolStripMenuItem[] { smNuevo, smHistorial, smProductos, smCategorias, smRVentas };

            foreach (var menu in menus)
            {
                var encontrado = menusPadre.Exists(x => x.NombreMenu == menu.Tag!.ToString() && x.Activo);

                if (encontrado)
                    menu.Visible = true;
                else
                    menu.Visible = false;

            }

            foreach (var submenu in submenus)
            {
                var encontrado = menusHijo
                    .Exists(x => x.NombreMenu == submenu.Tag!.ToString() && x.Activo);

                if (encontrado)
                    submenu.Visible = true;
                else
                    submenu.Visible = false;

            }

        }

        private void smNuevo_Click(object sender, EventArgs e)
        {
            MostrarFormulario<FrmVenta>();
        }

        private void smHistorial_Click(object sender, EventArgs e)
        {
            MostrarFormulario<FrmHistorial>();
        }

        private void smProductos_Click(object sender, EventArgs e)
        {
            MostrarFormulario<FrmProducto>();
        }

        private void smCategorias_Click(object sender, EventArgs e)
        {
            MostrarFormulario<frmCategoria>();
        }

        private void smRVentas_Click(object sender, EventArgs e)
        {
            MostrarFormulario<FrmReporteVenta>();
        }

        private void mnUsuarios_Click(object sender, EventArgs e)
        {
            MostrarFormulario<FrmUsuario>();
        }

        private void mnConfiguracion_Click(object sender, EventArgs e)
        {
            MostrarFormulario<FrmNegocio>();
        }

        private void linkCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
