using DAL.DALApi;
using DAL.DALImplementation;
using DAL.DALModels;
using Microsoft.Extensions.DependencyInjection;


namespace DAL;

public class DALManager
{
    public DALCostumerService Costumers { get; }

    public DALManager() 
    {
        ServiceCollection services = new();
        services.AddDbContext<Context>();
        services.AddScoped<IDALCostumerService, DALCostumerService>();

        ServiceProvider servicesProvider = services.BuildServiceProvider();
        Costumers = (DALCostumerService)servicesProvider.GetRequiredService<IDALCostumerService>();
    }
}
