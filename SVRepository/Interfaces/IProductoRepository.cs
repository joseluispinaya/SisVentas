using SVRepository.Entities;

namespace SVRepository.Interfaces
{
    public interface IProductoRepository
    {
        Task<List<Producto>> Lista(string buscar = "");
        //Task<List<Categoria>> Lista(string buscar = "");
        Task<string> Crear(Producto objeto);
        Task<string> Editar(Producto objeto);
    }
}
