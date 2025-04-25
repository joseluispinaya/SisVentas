using SVRepository.Entities;

namespace SVRepository.Interfaces
{
    public interface IMedidaRepository
    {
        Task<List<Medida>> Lista();
        //Task<List<Medida>> Lista();
    }
}
