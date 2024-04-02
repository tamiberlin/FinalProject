using BL.BLModels;
using Common;
using DAL.DALModels1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLApi
{
    public interface IBLCostumerService
    {
            Task<List<Costumer>> GetAllAsync();
            Task<bool> CreateAsync(Costumer costumer);
            Task<bool> UpdateAsync(Costumer costumer);
            Task<bool> DeleteAsync(params string[] list);
        public List<BLCostumer> GetAll(BaseQueryParams queryParams);
    }
}
