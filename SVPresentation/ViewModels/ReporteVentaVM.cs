using System.ComponentModel;

namespace SVPresentation.ViewModels
{
    public class ReporteVentaVM
    {
        [DisplayName("Numero Venta")]
        public string NumeroVenta { get; set; } = null!;

        [DisplayName("Nombre Usuario")]
        public string NombreUsuario { get; set; } = null!;

        [DisplayName("Fecha Registro")]
        public string FechaRegistro { get; set; } = null!;
        public string Producto { get; set; } = null!;

        [DisplayName("Precio Compra")]
        public decimal PrecioCompra { get; set; }

        [DisplayName("Precio Venta")]
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }

        [DisplayName("Precio Total")]
        public decimal PrecioTotal { get; set; }
    }
}
