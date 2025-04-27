using System.ComponentModel;

namespace SVPresentation.ViewModels
{
    public class ProductoVM
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int IdCategoria { get; set; }
        public string Categoria { get; set; } = null!;

        [DisplayName("Precio Compra")]
        public string PrecioCompra { get; set; } = null!;

        [DisplayName("Precio Venta")]
        public string PrecioVenta { get; set; } = null!;
        public int Cantidad { get; set; }
        public int Activo { get; set; }
        public string? Habilitado { get; set; }
    }
}
