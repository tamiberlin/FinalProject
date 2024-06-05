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

public class BLRoomService : IBLRoomService
{
    DALRoomService roomService;
    public BLRoomService(DALManager roomService)
    {
        this.roomService = roomService.Rooms;
    }
    public Task<Room> Create(BLRoom entity)
    {
        throw new NotImplementedException();
    }

    public Task<Room> Delete(string id)
    {
        throw new NotImplementedException();
    }

    public List<BLRoom> GetAll(BaseQueryParams queryParams)
    {
        Task<PagedList<Room>> pagedRooms = roomService.GetAllAsync(queryParams);
        List<BLRoom> roomList = new List<BLRoom>();
        foreach (var room in pagedRooms.Result)
        {
            BLRoom newRoom = new BLRoom();
            newRoom.RoomId = room.RoomId;
            newRoom.RoomNumber = room.RoomNumber;
            newRoom.NumOfBeds = room.NumOfBeds;
            newRoom.HouseCode = room.HouseCode;
            roomList.Add(newRoom);
        }
        return roomList;
    }

    public Task<Room> Update(string id, BLRoom entity)
    {
        throw new NotImplementedException();
    }
}
