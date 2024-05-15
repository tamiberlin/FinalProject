using BL.BLApi;
using BL.BLImplementation;
using BL.BLModels;
using Microsoft.Extensions.DependencyInjection;


namespace BL;

public class BLManager
{
    public BLCostumerService BLCostumer { get; }

    public BLManager()
    {
        ServiceCollection services = new();
        services.AddScoped<BLCostumer>();
        services.AddScoped<IBLCostumerService, BLCostumerService>();

        ServiceProvider servicesProvider = services.BuildServiceProvider();
        BLCostumer = (BLCostumerService)servicesProvider.GetRequiredService<IBLCostumerService>();
    }
}
