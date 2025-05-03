using SVRepository.Entities;
using SVRepository.Interfaces;
using SVServices.Interfaces;

namespace SVServices.Implemetation
{
    public class RolService : IRolService
    {
        private readonly IRolRepository _rolRepository;
        //private readonly IRolRepository _rolRepository;
        public RolService(IRolRepository rolRepository)
        {
            _rolRepository = rolRepository;
        }
        public async Task<List<Rol>> Lista()
        {
            return await _rolRepository.Lista();
        }
    }
}
