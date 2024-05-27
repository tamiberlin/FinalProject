using Common;
using DAL.DALApi;
using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation;

public class DALAtractionService : IDALAtractionService
{
    Context context;
    public DALAtractionService(Context context)
    {
        this.context = context;
    }

    public Task<Attraction> CreateAsync(Attraction entity)
    {
        throw new NotImplementedException();
    }

    public Task<Attraction> DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<PagedList<Attraction>> GetAllAsync(BaseQueryParams queryParams)
    {
        var queryable = context.Attractions.AsQueryable();
        return PagedList<Attraction>.ToPagedList(queryable, queryParams.PageNumber, queryParams.PageSize);
    }

    public Task<Attraction> UpdateAsync(string id, Attraction entity)
    {
        throw new NotImplementedException();
    }
}
