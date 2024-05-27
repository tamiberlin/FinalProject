using Common;
using DAL.DALApi;
using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation;

public class DALDestinationService : IDALDestinationService
{
    Context context;
    public DALDestinationService(Context context)
    {
        this.context = context;
    }

    public Task<Destination> CreateAsync(Destination entity)
    {
        throw new NotImplementedException();
    }

    public Task<Destination> DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<PagedList<Destination>> GetAllAsync(BaseQueryParams queryParams)
    {
      var queryable = context.Destinations.AsQueryable();
        return PagedList<Destination>.ToPagedList(queryable, queryParams.PageNumber, queryParams.PageSize);
    }

    public Task<Destination> UpdateAsync(string id, Destination entity)
    {
        throw new NotImplementedException();
    }
}
