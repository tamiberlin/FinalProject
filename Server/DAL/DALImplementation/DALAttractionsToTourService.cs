using Common;
using DAL.DALApi;
using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation;

public class DALAttractionsToTourService : IDALAttractionsToTourService
{
    Context context;
    public DALAttractionsToTourService(Context context)
    {
        this.context = context;
    }

    public Task<AtractionsToTour> CreateAsync(AtractionsToTour entity)
    {
        throw new NotImplementedException();
    }

    public Task<AtractionsToTour> DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<PagedList<AtractionsToTour>> GetAllAsync(BaseQueryParams queryParams)
    {
        var queryable = context.AtractionsToTours.AsQueryable();
        return PagedList<AtractionsToTour>.ToPagedList(queryable, queryParams.PageNumber, queryParams.PageSize);
    }

    public Task<AtractionsToTour> UpdateAsync(string id, AtractionsToTour entity)
    {
        throw new NotImplementedException();
    }
}
