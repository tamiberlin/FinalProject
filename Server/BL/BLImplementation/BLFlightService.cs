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
        Task<PagedList<Flight>> pagedFlights = flightService.GetAllAsync(queryParams);
        List<BLFlight> flightList = new List<BLFlight>();
        foreach (var flight in pagedFlights.Result)
        {
            BLFlight newFlight = new BLFlight();
            newFlight.ArrivalTime = flight.ArrivalTime;
            newFlight.Price = flight.Price;
            newFlight.LeavingTime = flight.LeavingTime;
            newFlight.Company = flight.Company;
            newFlight.Date = flight.Date;
            newFlight.DepartureCode = flight.DepartureCode;
            newFlight.DestinationCode = flight.DestinationCode;
            newFlight.FlightId = flight.FlightId;
            flightList.Add(newFlight);
        }
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
