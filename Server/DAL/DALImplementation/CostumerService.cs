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
        #endregion

        #region Update functions
        public Task<bool> UpdateAsync(  Costumer entity)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
