using BL.BLApi;
using BL.BLModels;
using Common;
using DAL;
using DAL.DALImplementation;
using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLImplementation;

public class BLFlightService : IBLFlightService
{
    DALFlightService flightService;

    public BLFlightService(DALManager flightService)
    {
        this.flightService = flightService.Flights;
    }

    public List<BLFlight> GetAll(BaseQueryParams queryParams)
    {
        // Fetch data from the DAL asynchronously
        Task<PagedList<Flight>> pagedFlightsTask = flightService.GetAllAsync(queryParams);

        // Wait for the task to complete and get the result
        PagedList<Flight> pagedFlights = pagedFlightsTask.Result;

        // Ensure pagedFlights and its Items property are not null
        if (pagedFlights == null || pagedFlights.Count == 0)
        {
            return new List<BLFlight>(); // Return an empty list if no data is found
        }

        // Map to BLFlight with null checks for navigation properties
        List<BLFlight> flightList = pagedFlights.Select(flight => new BLFlight
        {
            FlightId = flight.FlightId,
            DepartureCode = flight.DepartureCode,
            DepartureCity = flight.DepartureCodeNavigation?.CityName ?? "Unknown",
            DepartureCountry = flight.DepartureCodeNavigation?.CountryName ?? "Unknown",
            DestinationCode = flight.DestinationCode,
            DestinationCity = flight.DestinationCodeNavigation?.CityName ?? "Unknown",
            DestinationCountry = flight.DestinationCodeNavigation?.CountryName ?? "Unknown",
            Date = flight.Date,
            LeavingTime = flight.LeavingTime,
            ArrivalTime = flight.ArrivalTime,
            Company = flight.Company,
            Price = flight.Price,
            AmountOfSeats = flight.AmountOfSeats,
            BookedSeats = flight.BookedSeats
        }).ToList();

        return flightList;
    }

    public Task<Flight> Create(BLFlight entity)
    {
        throw new NotImplementedException();
    }

    public Task<Flight> Delete(string id)
    {
        throw new NotImplementedException();
    }

    public Task<Flight> Update(string id, BLFlight entity)
    {
        throw new NotImplementedException();
    }

}
