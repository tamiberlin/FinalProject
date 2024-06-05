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
    public BLTourService BLTour { get; }
    public BLHousingService BLHousing { get; }
    public BLRoomService BLRoom { get; }
    public BLPaymentService BLPayment { get; }
    public BLDatesForRoomsService BLDatesForRooms { get; }
    public BLAtractionsToTourService BLAtractionsToTours { get; }
    
    public BLManager()
    {
        ServiceCollection services = new();
        services.AddScoped<DALManager>();
        services.AddScoped<IBLCostumerService, BLCostumerService>();
        services.AddScoped<IBLFlightService, BLFlightService>();
        services.AddScoped<IBLDestinationService, BLDestinationService>();
        services.AddScoped<IBLAttractionService, BLAttractionService>();
        services.AddScoped<IBLTourService, BLTourService>();  
        services.AddScoped<IBLHousingService, BLHousingService>();
        services.AddScoped<IBLRoomService, BLRoomService>();
        services.AddScoped<IBLPaymentService, BLPaymentService>();
        services.AddScoped<IBLDatesForRoomsService, BLDatesForRoomsService>();
        services.AddScoped<IBLAtractionsToTourService, BLAtractionsToTourService>();

        ServiceProvider servicesProvider = services.BuildServiceProvider();

        BLCostumer = (BLCostumerService)servicesProvider.GetRequiredService<IBLCostumerService>();
        BLFlight = (BLFlightService)servicesProvider.GetRequiredService<IBLFlightService>();
        BLDestination = (BLDestinationService)servicesProvider.GetRequiredService<IBLDestinationService>();
        BLAttraction = (BLAttractionService)servicesProvider.GetRequiredService<IBLAttractionService>();
        BLTour = (BLTourService)servicesProvider.GetRequiredService<IBLTourService>();
        BLHousing = (BLHousingService)servicesProvider.GetRequiredService<IBLHousingService>();
        BLRoom = (BLRoomService)servicesProvider.GetRequiredService<IBLRoomService>();
        BLPayment = (BLPaymentService)servicesProvider.GetRequiredService<IBLPaymentService>();
        BLDatesForRooms = (BLDatesForRoomsService)servicesProvider.GetRequiredService<IBLDatesForRoomsService> ();
        BLAtractionsToTours = (BLAtractionsToTourService)servicesProvider.GetRequiredService<IBLAtractionsToTourService> ();
    }
}
