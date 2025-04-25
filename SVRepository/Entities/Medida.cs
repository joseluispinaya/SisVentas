namespace SVRepository.Entities
{
    public class Medida
    {
        public int IdMedida { get; set; }
        public string Nombre { get; set; } = null!;
        public string Abreviatura { get; set; } = null!;
        public string Equivalente { get; set; } = null!;
        public int Valor { get; set; }
    }
}
