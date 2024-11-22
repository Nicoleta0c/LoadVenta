
using LoadDwhVenta.Data.Contexts.DwVentas;
using LoadDwhVenta.Data.Contexts.Nortwind;
using LoadDWVentas.Data.Interfaces;
using LoadDWVentas.Data.Services;
using LoadDWVentas.WorkerService;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }
    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
        .ConfigureServices((hostContext, services) => {

            services.AddDbContextPool<NorthwindContext>(options =>
                                                      options.UseSqlServer(hostContext.Configuration.GetConnectionString("Northwind")));

            services.AddDbContextPool<DwhVentasContext>(options =>
                                                      options.UseSqlServer(hostContext.Configuration.GetConnectionString("DwhVentas")));


            services.AddScoped<IDataServiceDwVentas, DataServiceDwVentas>();


            services.AddHostedService<Worker>();
        });
}