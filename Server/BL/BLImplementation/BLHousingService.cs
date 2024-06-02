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

public class BLHousingService : IBLHousingService
{
    DALHousingService housingService;
    public BLHousingService(DALManager housingService)
    {
        this.housingService = housingService.Housings;
    }
    public Task<Housing> Create(BLHousing entity)
    {
        throw new NotImplementedException();
    }

    public Task<Housing> Delete(string id)
    {
        throw new NotImplementedException();
    }

    public List<BLHousing> GetAll(BaseQueryParams queryParams)
    {
       Task<PagedList<Housing>> pagedHousing = housingService.GetAllAsync(queryParams);
        List<BLHousing> housingList = new List<BLHousing>();
        foreach(var housing in pagedHousing.Result)
        {
            BLHousing newHousing = new BLHousing();
            newHousing.HouseId = housing.HouseId;
            newHousing.Rooms = housing.Rooms;
            newHousing.AddressCode = housing.AddressCode;
            newHousing.IsHotel = housing.IsHotel;
            newHousing.Email = housing.Email;
            newHousing.HouseName = housing.HouseName;
            housingList.Add(newHousing);
        }
        return housingList;
    }

    public Task<Housing> Update(string id, BLHousing entity)
    {
        throw new NotImplementedException();
    }
}
