using BL.BLApi;
using BL.BLImplementation;
using BL.BLModels;
using DAL;
using Microsoft.Extensions.DependencyInjection;


namespace BL;

public class BLManager
{
    public BLCostumerService BLCostumer { get; }
    public BLFlightService BLFlight { get; }
    public BLDestinationService BLDestination { get; }
    public BLAttractionService BLAttraction { get; }
    public BLManager()
    {
        ServiceCollection services = new();
        services.AddScoped<DALManager>();
        services.AddScoped<IBLCostumerService, BLCostumerService>();
        services.AddScoped<IBLFlightService, BLFlightService>();
        services.AddScoped<IBLDestinationService, BLDestinationService>();
        services.AddScoped<IBLAttractionService, BLAttractionService>();
        ServiceProvider servicesProvider = services.BuildServiceProvider();
        BLCostumer = (BLCostumerService)servicesProvider.GetRequiredService<IBLCostumerService>();
        BLFlight = (BLFlightService)servicesProvider.GetRequiredService<IBLFlightService>();
        BLDestination = (BLDestinationService)servicesProvider.GetRequiredService<IBLDestinationService>();
        BLAttraction = (BLAttractionService)servicesProvider.GetRequiredService<IBLAttractionService>();
    }
}
