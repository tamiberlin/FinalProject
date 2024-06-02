using Common;
using DAL.DALApi;
using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation;

public class DALTourService : IDALTourService
{
    Context context;
    public DALTourService(Context context)
    {
        this.context = context;
    }

    public Task<Tour> CreateAsync(Tour entity)
    {
        throw new NotImplementedException();
    }

    public Task<Tour> DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<PagedList<Tour>> GetAllAsync(BaseQueryParams queryParams)
    {
        var queryable = context.Tours.AsQueryable();
        return PagedList<Tour>.ToPagedList(queryable, queryParams.PageNumber, queryParams.PageSize);
    }

    public Task<Tour> UpdateAsync(string id, Tour entity)
    {
        throw new NotImplementedException();
    }
}
