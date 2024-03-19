using BL.BLApi;
using DAL.DALModels1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLImplementation
{
    internal class CostumerService : ICostumerService
    {
        public Task<bool> CreateAsync(Costumer costumer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(params string[] list)
        {
            throw new NotImplementedException();
        }

        public Task<List<Costumer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Costumer costumer)
        {
            throw new NotImplementedException();
        }
    }
}
