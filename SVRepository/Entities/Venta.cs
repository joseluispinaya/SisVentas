namespace SVRepository.Entities
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public string NumeroVenta { get; set; } = null!;
        public Usuario? UsuarioRegistro { get; set; }
        public string NombreCliente { get; set; } = null!;
        public decimal PrecioTotal { get; set; }
        public int CantidadTotal { get; set; }
        public string FechaRegistro { get; set; } = null!;
        public int Activo { get; set; }
        public List<DetalleVenta>? RefDetalleVenta { get; set; }
    }
}
