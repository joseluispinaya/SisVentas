using Microsoft.Extensions.DependencyInjection;
using SVPresentation.Utilidades;
using SVServices.Interfaces;

namespace SVPresentation.Formularios
{
    public partial class FrmLogin : Form
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IServiceProvider _serviceProvider;
        public FrmLogin(IUsuarioService usuarioService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
            _serviceProvider = serviceProvider;
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txbUsuario.Select();
        }

        private async void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbUsuario.Text))
            {
                MensajeError("Debe ingresar su usuario.");
                txbUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txbContrasena.Text))
            {
                MensajeError("Debe ingresar una Contraseña.");
                txbContrasena.Focus();
                return;
            }

            var encontrado = await _usuarioService.Login(txbUsuario.Text, txbContrasena.Text);

            if (encontrado.IdUsuario == 0)
            {
                MensajeError("No se encontro el usuario");
                return;
            }

            if (encontrado.Activo == 0)
            {
                MensajeError("El usuario esta deshabilitado");
                return;
            }

            if (encontrado.ResetearClave == 1)
            {
                MensajeError("El usuario debe resetear clave");
                //return;
            }
            else
            {
                UsuarioSesion.IdUsuario = encontrado.IdUsuario;
                UsuarioSesion.NombreUsuario = encontrado.NombreUsuario;
                UsuarioSesion.NombreCompleto = encontrado.NombreCompleto;
                UsuarioSesion.IdRol = encontrado.RefRol!.IdRol;
                UsuarioSesion.Rol = encontrado.RefRol.Nombre!;

                var _formLayout = _serviceProvider.GetRequiredService<Layout>();
                this.Hide();
                txbUsuario.Text = "";
                txbContrasena.Text = "";

                _formLayout.Show();
                _formLayout.FormClosed += (sender, e) =>
                {
                    this.Show();
                    txbUsuario.Select();
                };
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
