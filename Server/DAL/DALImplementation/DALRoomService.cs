using Common;
using DAL.DALApi;
using DAL.DALModels;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation;

public class DALRoomService : IDALRoomService
{
    Context context;
    public DALRoomService(Context context)
    {
        this.context = context;
    }
    public Task<Room> CreateAsync(Room entity)
    {
        throw new NotImplementedException();
    }

    public Task<Room> DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<PagedList<Room>> GetAllAsync(BaseQueryParams queryParams)
    {
        var queryable = context.Rooms.AsQueryable();
        return PagedList<Room>.ToPagedList(queryable, queryParams.PageNumber, queryParams.PageSize);
    }

    public Task<Room> UpdateAsync(string id, Room entity)
    {
        throw new NotImplementedException();
    }
}
