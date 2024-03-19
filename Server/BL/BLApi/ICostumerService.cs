using DAL.DALModels1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLApi
{
    internal interface ICostumerService
    {
            Task<List<Costumer>> GetAllAsync();
            Task<bool> CreateAsync(Costumer costumer);
            Task<bool> UpdateAsync(Costumer costumer);
            Task<bool> DeleteAsync(params string[] list);
    }
}
