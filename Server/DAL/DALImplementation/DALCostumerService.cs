using Common;
using DAL.DALApi;
using DAL.DALModels;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;


namespace DAL.DALImplementation;

public class DALCostumerService : IDALCostumerService
{
    Context context;
    public DALCostumerService(Context context)
    {
        this.context = context;
    }

    #region Create functions
    public Task<bool> CreateAsync(Costumer entity)
    {
        throw new NotImplementedException();
    }

    public Task<Costumer> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
    #endregion

    #region Delete functions

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

    //public Task<List<Costumer>> GetAllAsync(BaseQueryParams queryParams)
    //{
    //    throw new NotImplementedException();
    //}



    //public Task<List<Costumer>> GetAllAsync(BaseQueryParams queryParams)
    //{
    //    throw new NotImplementedException();
    //}

    //public Task<Costumer> GetSingleAsync(int id)
    //{
    //    throw new NotImplementedException();
}
#endregion

#region Update functions

    #endregion
