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

    #region Get functions

    public async Task<PagedList<Costumer>> GetAllAsync(BaseQueryParams queryParams)
    {
        var queryable = context.Costumers.AsQueryable();
        return PagedList<Costumer>.ToPagedList(queryable, queryParams.PageNumber, queryParams.PageSize);

    }

    public async Task<Costumer> GetByIdAsync(string id)
    {
        try
        {
            return await context.Costumers.Where(c => String.Equals(id,c.CostumerId)).FirstOrDefaultAsync();
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception($"failed to load costumer: {id}");
        }
    }
    #endregion

    #region Create function
    public async Task<Costumer> CreateAsync(Costumer entity)
    {
        try
        {
            context.Costumers.Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            throw new Exception("failed to add a new costumer");
        }
    }


    #endregion

    #region Delete function
    public async Task<Costumer> DeleteAsync(String id)
    {
        try
        {
            Costumer costumer = context.Costumers.FirstOrDefault(c => c.CostumerId.Equals(id));
            if (costumer != null)
            {
                context.Costumers.Remove(costumer);
            }
            await context.SaveChangesAsync();
            return costumer;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception($"failed to dalete costumer : {id}");
        }
    }
    #endregion

    #region Update functions// doesnt work well!!!
    public async Task<Costumer> UpdateAsync(string id, Costumer entity)
    {
        try
        {
            Costumer? costumer = context.Costumers.FirstOrDefault(c => c.CostumerId.Equals(id));
            if (costumer != null)
            {
                costumer.CostumerName = entity.CostumerName;
                costumer.PhoneNumber = entity.PhoneNumber;
                costumer.CostumerId = entity.CostumerId;
                costumer.Email = entity.Email;
                costumer.OrdersToCosumers = entity.OrdersToCosumers;
                costumer.NumberOfPeople = entity.NumberOfPeople;
                
                context.SaveChangesAsync();
                return costumer;
            }
            return costumer;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception($"failed to update costumer : {id}");
        }
    }
    #endregion

}