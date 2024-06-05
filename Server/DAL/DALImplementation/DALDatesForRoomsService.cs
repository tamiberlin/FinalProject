using Common;
using DAL.DALApi;
using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation;

public class DALDatesForRoomsService : IDALDatesForRoomsService
{
    Context context;
    public DALDatesForRoomsService(Context context)
    {
        this.context = context;
    }
    public Task<DatesForRoom> CreateAsync(DatesForRoom entity)
    {
        throw new NotImplementedException();
    }

    public Task<DatesForRoom> DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<PagedList<DatesForRoom>> GetAllAsync(BaseQueryParams queryParams)
    {
        var queryable = context.DatesForRooms.AsQueryable();
        return PagedList<DatesForRoom>.ToPagedList(queryable, queryParams.PageNumber, queryParams.PageSize);
    }

    public Task<DatesForRoom> UpdateAsync(string id, DatesForRoom entity)
    {
        throw new NotImplementedException();
    }
}
