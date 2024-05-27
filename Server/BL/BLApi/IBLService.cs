using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLApi;

public interface IBLService<T, V>
{
    List<T> GetAll(BaseQueryParams queryParams);
    Task<V> Create(T entity);
    Task<V> Delete(string id);
    Task<V> Update(string id, T entity);
}
