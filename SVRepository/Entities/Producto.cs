namespace SVRepository.Entities
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public Categoria? RefCategoria { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public int Activo { get; set; }
    }
}
