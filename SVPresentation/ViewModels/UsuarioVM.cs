using System.ComponentModel;

namespace SVPresentation.ViewModels
{
    public class UsuarioVM
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public string Rol { get; set; } = null!;

        [DisplayName("Nombre Completo")]
        public string NombreCompleto { get; set; } = null!;
        public string Correo { get; set; } = null!;

        [DisplayName("Nombre Usuario")]
        public string NombreUsuario { get; set; } = null!;
        public string Clave { get; set; } = null!;
        //public int ResetearClave { get; set; }
        public int Activo { get; set; }
        public string? Habilitado { get; set; }
    }
}
