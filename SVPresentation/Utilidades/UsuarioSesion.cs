namespace SVPresentation.Utilidades
{
    public static class UsuarioSesion
    {
        public static int IdUsuario { get; set; }
        public static string NombreUsuario { get; set; } = null!;
        public static string NombreCompleto { get; set; } = null!;
        public static int IdRol { get; set; }
        public static string Rol { get; set; } = null!;
    }
}
