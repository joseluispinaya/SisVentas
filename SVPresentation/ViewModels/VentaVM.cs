using System.ComponentModel;

namespace SVPresentation.ViewModels
{
    public class VentaVM
    {
        [DisplayName("Fecha Registro")]
        public string FechaRegistro { get; set; } = null!;
        public string NumeroVenta { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string Cliente { get; set; } = null!;

        [DisplayName("Cant Total")]
        public int CantidadTotal { get; set; }
        public decimal Total { get; set; }
    }
}
