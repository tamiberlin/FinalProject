using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALApi;

public interface IDALService<T>
{
    
    Task<PagedList<T>> GetAllAsync(BaseQueryParams queryParams);
    Task<T> CreateAsync(T entity);
    Task<T> UpdateAsync(String id, T entity);
    Task<T> DeleteAsync(String id);
}
