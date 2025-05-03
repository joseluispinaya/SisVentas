using Microsoft.Extensions.DependencyInjection;
using SVRepository.DB;
using SVRepository.Implementation;
using SVRepository.Interfaces;

namespace SVRepository
{
    public static class DependecyInjection
    {
        public static void RegisterRepositoryDependecies(this IServiceCollection services)
        {
            services.AddSingleton<Conexion>();
            services.AddTransient<IMedidaRepository, MedidaRepository>();
            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<IProductoRepository, ProductoRepository>();
            services.AddTransient<INegocioRepository, NegocioRepository>();
            services.AddTransient<IRolRepository, RolRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IVentaRepository, VentaRepository>();
            services.AddTransient<IMenuRolRepository, MenuRolRepository>();
        }
    }
}
