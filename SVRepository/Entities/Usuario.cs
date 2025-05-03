namespace SVRepository.Entities
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public Rol? RefRol { get; set; }
        public string NombreCompleto { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string NombreUsuario { get; set; } = null!;
        public string Clave { get; set; } = null!;
        public int ResetearClave { get; set; }
        public int Activo { get; set; }
    }
}
