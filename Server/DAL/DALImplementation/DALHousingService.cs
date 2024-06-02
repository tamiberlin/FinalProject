using Common;
using DAL.DALApi;
using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation;

public class DALHousingService : IDALHousingService
{
    Context context;

    public DALHousingService(Context context)
    {
        this.context = context;
    }

    public Task<Housing> CreateAsync(Housing entity)
    {
        throw new NotImplementedException();
    }

    public Task<Housing> DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<PagedList<Housing>> GetAllAsync(BaseQueryParams queryParams)
    {
        var queryable = context.Housings.AsQueryable();
        return PagedList<Housing>.ToPagedList(queryable, queryParams.PageNumber, queryParams.PageSize);
    }

    public Task<Housing> UpdateAsync(string id, Housing entity)
    {
        throw new NotImplementedException();
    }
}
