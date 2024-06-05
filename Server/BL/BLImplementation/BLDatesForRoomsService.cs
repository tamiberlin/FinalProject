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

public class BLDatesForRoomsService : IBLDatesForRoomsService
{
    DALDatesForRoomsService datesForRoomsService;
    public BLDatesForRoomsService(DALManager datesForRoomsService)
    {
        this.datesForRoomsService = datesForRoomsService.DatesForRooms;
    }
    public Task<DatesForRoom> Create(BLDatesForRooms entity)
    {
        throw new NotImplementedException();
    }

    public Task<DatesForRoom> Delete(string id)
    {
        throw new NotImplementedException();
    }

    public List<BLDatesForRooms> GetAll(BaseQueryParams queryParams)
    {
        Task<PagedList<DatesForRoom>> pagedDatesForRooms = datesForRoomsService.GetAllAsync(queryParams);
        List<BLDatesForRooms> datesForRoomsList = new List<BLDatesForRooms>();
        foreach(var dForR in pagedDatesForRooms.Result)
        {
            BLDatesForRooms newDate = new BLDatesForRooms();
            newDate.DateId = dForR.DateId;
            newDate.CostumerCode = dForR.CostumerCode;
            newDate.StartDate = dForR.StartDate;
            newDate.EndDate = dForR.EndDate;   
            newDate.RoomCode = dForR.RoomCode;
            datesForRoomsList.Add(newDate);
        }
        return datesForRoomsList;
    }

    public Task<DatesForRoom> Update(string id, BLDatesForRooms entity)
    {
        throw new NotImplementedException();
    }
}
