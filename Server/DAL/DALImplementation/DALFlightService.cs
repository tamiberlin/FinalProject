using Common;
using DAL.DALApi;
using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation;

public class DALFlightService:IDALFlightService
{
    Context context;
    public DALFlightService(Context context)
    {
        this.context = context;
    }

    public Task<Flight> CreateAsync(Flight entity)
    {
        throw new NotImplementedException();
    }

    public Task<Flight> DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    #region Get functions

    public async Task<PagedList<Flight>> GetAllAsync(BaseQueryParams queryParams)
    {
        var queryable = context.Flights.AsQueryable();
        return PagedList<Flight>.ToPagedList(queryable, queryParams.PageNumber, queryParams.PageSize);
    }
    #endregion

    public Task<Flight> UpdateAsync(string id, Flight entity)
    {
        throw new NotImplementedException();
    }

    
}
