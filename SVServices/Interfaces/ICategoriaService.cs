using SVRepository.Entities;

namespace SVServices.Interfaces
{
    public interface ICategoriaService
    {
        Task<List<Categoria>> Lista(string buscar = "");
        //Task<List<Categoria>> Lista(string buscar = "");
        Task<string> Crear(Categoria objeto);
        Task<string> Editar(Categoria objeto);
    }
}
