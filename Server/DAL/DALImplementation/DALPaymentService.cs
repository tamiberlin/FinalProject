using Common;
using DAL.DALApi;
using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation;

public class DALPaymentService : IDALPaymentService
{
    Context context;
    public DALPaymentService(Context context)
    {
        this.context = context;
    }

    public Task<Payment> CreateAsync(Payment entity)
    {
        throw new NotImplementedException();
    }

    public Task<Payment> DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<PagedList<Payment>> GetAllAsync(BaseQueryParams queryParams)
    {
        var queryable = context.Payments.AsQueryable();
        return PagedList<Payment>.ToPagedList(queryable, queryParams.PageNumber, queryParams.PageSize);
    }

    public Task<Payment> UpdateAsync(string id, Payment entity)
    {
        throw new NotImplementedException();
    }
}
