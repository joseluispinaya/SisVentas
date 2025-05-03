using SVRepository.Entities;

namespace SVServices.Interfaces
{
    public interface IUsuarioService
    {
        Task<List<Usuario>> Lista(string buscar = "");
        Task<string> Crear(Usuario objeto);
        Task<string> Editar(Usuario objeto);
        Task<Usuario> Login(string usuario, string clave);
        Task<int> VerificarCorreo(string correo);
        Task ActualizarClave(int idUsuario, string nuevaClave, int resetear);
    }
}
