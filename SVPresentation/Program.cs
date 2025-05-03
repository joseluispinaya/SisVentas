using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SVPresentation.Formularios;
using SVRepository;
using SVRepository.Implementation;
using SVRepository.Interfaces;
using SVServices;
using SVServices.Implemetation;
using SVServices.Interfaces;

namespace SVPresentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            var formService = host.Services.GetRequiredService<FrmLogin>();
            //Application.Run(new Form1());
            Application.Run(formService);
        }

        static IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) => {
                config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            })
            .ConfigureServices((context, services) =>
            {
                services.RegisterRepositoryDependecies();
                services.RegisterServicesDependecies();

                //services.AddTransient<Form1>();
                services.AddTransient<frmCategoria>();
                services.AddTransient<FrmProducto>();
                services.AddTransient<FrmNegocio>();
                services.AddTransient<FrmUsuario>();
                services.AddTransient<FrmVenta>();
                services.AddTransient<FrmBuscarProducto>();
                services.AddTransient<FrmHistorial>();
                services.AddTransient<FrmDetalleVenta>();
                services.AddTransient<FrmReporteVenta>();
                services.AddTransient<FrmLogin>();
                services.AddTransient<Layout>();
            });
    }
}