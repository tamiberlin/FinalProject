using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALApi;

public interface IDALService<T>
{
    //Task<List<T>> GetAllAsync(BaseQueryParams queryParams);
    Task<List<T>> GetAllAsync();
    //    Task<T> GetSingleAsync(int id);
    //    Task<T> AddAsync(T entity);
    //    Task<T> UpdateAsync(int id, T entity);
    //    Task<T> DeleteAsync(int id);
}
