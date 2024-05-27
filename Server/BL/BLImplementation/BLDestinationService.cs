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

public class BLDestinationService : IBLDestinationService
{
    DALDestinationService destinationService;
    public BLDestinationService(DALManager destinationService)
    {
        this.destinationService = destinationService.Destinations;
    }
    public Task<Destination> Create(BLDestination entity)
    {
        throw new NotImplementedException();
    }

    public Task<Destination> Delete(string id)
    {
        throw new NotImplementedException();
    }

    public List<BLDestination> GetAll(BaseQueryParams queryParams)
    {
      Task<PagedList<Destination>> pagedDestinations = destinationService.GetAllAsync(queryParams);
        List<BLDestination> destinationList  = new List<BLDestination>();
        foreach(var destination  in pagedDestinations.Result) 
        {
        BLDestination newDestination = new BLDestination();
            newDestination.DestinationId = destination.DestinationId;
            newDestination.CountryName = destination.CountryName;
            newDestination.CityName = destination.CityName;
            destinationList.Add(newDestination);
        }
        return destinationList;
    }

    public Task<Destination> Update(string id, BLDestination entity)
    {
        throw new NotImplementedException();
    }
}
