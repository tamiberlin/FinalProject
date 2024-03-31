using Common;
using DAL.DALApi;
using DAL.DALModels1;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation
{
    internal class CostumerService : ICostumerService
    {
        Context context;
        public CostumerService(Context context)
        {
            this.context = context;
        }

        public Task<Costumer> AddAsync(Costumer entity)
        {
            throw new NotImplementedException();
        }

        #region Create functions
        public Task<bool> CreateAsync(Costumer entity)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Delete functions
        public Task<bool> DeleteAsync(params string[] list)
        {
            throw new NotImplementedException();
        }

        public Task<Costumer> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Get functions
        public async Task<List<Costumer>> GetAllAsync()
        {
            try
            {
                List<Costumer> costumers = await context.Costumers.ToListAsync();
                return costumers == null ? throw new ArgumentNullException("No costumers in our system") : costumers;
            }
            catch (ArgumentNullException ex) 
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }
            catch (TimeoutException ex)
            {
                throw ex;
            }
        }

        public Task<PagedList<Costumer>> GetAllAsync(BaseQueryParams queryParams)
        {
            throw new NotImplementedException();
        }

        public Task<Costumer> GetSingleAsync(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Update functions
        public Task<bool> UpdateAsync(  Costumer entity)
        {
            throw new NotImplementedException();
        }

        public Task<Costumer> UpdateAsync(int id, Costumer entity)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
