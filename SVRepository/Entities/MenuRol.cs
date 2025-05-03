namespace SVRepository.Entities
{
    public class MenuRol
    {
        public string NombreMenu { get; set; } = null!;
        public int IdMenuPadre { get; set; }
        public bool Activo { get; set; }
    }
}
