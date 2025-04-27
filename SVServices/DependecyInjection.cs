using Microsoft.Extensions.DependencyInjection;
using SVServices.Implemetation;
using SVServices.Interfaces;

namespace SVServices
{
    public static class DependecyInjection
    {
        public static void RegisterServicesDependecies(this IServiceCollection services)
        {
            services.AddTransient<IMedidaService, MedidaService>();
            services.AddTransient<ICategoriaService, CategoriaService>();
            services.AddTransient<IProductoService, ProductoService>();
        }
    }
}
