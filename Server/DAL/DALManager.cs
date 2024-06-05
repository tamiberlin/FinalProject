using DAL.DALApi;
using DAL.DALImplementation;
using DAL.DALModels;
using Microsoft.Extensions.DependencyInjection;


namespace DAL;

public class DALManager
{
    public DALCostumerService Costumers { get; }

    public DALFlightService Flights { get; }

    public DALDestinationService Destinations { get; }

    public DALAtractionService Atractions { get; }

    public DALTourService Tours { get; }

    public DALHousingService Housings { get; }

    public DALRoomService Rooms { get; }

    public DALPaymentService Payments { get; }
    public DALDatesForRoomsService DatesForRooms { get; }
    public DALAttractionsToTourService AtractionsToTours { get; }
    public DALManager() 
    {
        ServiceCollection services = new();
        services.AddDbContext<Context>();
        services.AddScoped<IDALCostumerService, DALCostumerService>();
        services.AddScoped<IDALFlightService, DALFlightService>();
        services.AddScoped<IDALDestinationService, DALDestinationService>();
        services.AddScoped<IDALAtractionService, DALAtractionService>();
        services.AddScoped<IDALTourService, DALTourService>();
        services.AddScoped<IDALHousingService, DALHousingService>();
        services.AddScoped<IDALRoomService, DALRoomService>();
        services.AddScoped<IDALPaymentService, DALPaymentService>();
        services.AddScoped<IDALDatesForRoomsService, DALDatesForRoomsService>();
        services.AddScoped<IDALAttractionsToTourService, DALAttractionsToTourService>();

        ServiceProvider servicesProvider = services.BuildServiceProvider();

        Costumers = (DALCostumerService)servicesProvider.GetRequiredService<IDALCostumerService>();
        Flights = (DALFlightService)servicesProvider.GetRequiredService<IDALFlightService>();
        Destinations = (DALDestinationService)servicesProvider.GetRequiredService<IDALDestinationService>();
        Atractions = (DALAtractionService)servicesProvider.GetRequiredService<IDALAtractionService>();
        Tours = (DALTourService)servicesProvider.GetRequiredService<IDALTourService>();
        Housings = (DALHousingService)servicesProvider.GetRequiredService<IDALHousingService>();
        Rooms = (DALRoomService)servicesProvider.GetRequiredService<IDALRoomService>();
        Payments = (DALPaymentService)servicesProvider.GetRequiredService<IDALPaymentService>();
        DatesForRooms = (DALDatesForRoomsService)servicesProvider.GetRequiredService<IDALDatesForRoomsService>();
        AtractionsToTours = (DALAttractionsToTourService)servicesProvider.GetRequiredService<IDALAttractionsToTourService>();
    }
}
