using System.ComponentModel;

namespace SVPresentation.ViewModels
{
    public class DetalleVentaVM
    {
        public int IdProducto { get; set; }
        public string Producto { get; set; } = null!;
        public decimal Precio { get; set; }
        public int CantidadValor { get; set; }

        [DisplayName("Cantidad")]
        public string CantidadTexto { get; set; } = null!;
        public decimal Total { get; set; }
    }
}
