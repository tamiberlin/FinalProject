using BL.BLApi;
using BL.BLModels;
using Common;
using DAL;
using DAL.DALImplementation;
using DAL.DALModels;
using Microsoft.Identity.Client;

namespace BL.BLImplementation
{
    public class BLCostumerService : IBLCostumerService
    {
        DALCostumerService costumerService;
        public BLCostumerService(DALManager costumerService)
        {
            this.costumerService = costumerService.Costumers;
        }


        #region Create function
        public Task<Costumer> Create(BLCostumer entity)
        {
            Costumer newCostumer = new Costumer();
            newCostumer.CostumerId = entity.CostumerId;
            newCostumer.CostumerName = entity.CostumerName;
            newCostumer.PhoneNumber = entity.PhoneNumber;
            newCostumer.NumberOfPeople = entity.NumberOfPeople;
            return costumerService.CreateAsync(newCostumer);
        }

        #endregion


        #region Get Functions
        public List<BLCostumer> GetAll(BaseQueryParams queryParams)
        {
            Task<PagedList<Costumer>> pagedCostumers = costumerService.GetAllAsync(queryParams);
            List<BLCostumer> usersList = new List<BLCostumer>();
            foreach (var costumer in pagedCostumers.Result)
            {
                BLCostumer newCostumer = new BLCostumer();
                newCostumer.CostumerName = costumer.CostumerName;
                newCostumer.CostumerId= costumer.CostumerId;
                newCostumer.NumberOfPeople= costumer.NumberOfPeople;
                usersList.Add(newCostumer);
            }
            return usersList;
        }

        public BLCostumer GetById(string id) 
        { 
            Task<Costumer> costumer = costumerService.GetByIdAsync(id);
            BLCostumer newCostumer = new BLCostumer();
            if(costumer.Result != null)
            {
            newCostumer.CostumerId = costumer.Result.CostumerId;
            newCostumer.CostumerName = costumer.Result.CostumerName;
            newCostumer.PhoneNumber = costumer.Result.PhoneNumber;
            newCostumer.NumberOfPeople = costumer.Result.NumberOfPeople;
            }
            return newCostumer;
        }

        #endregion


        #region Delete function
        public Task<Costumer> Delete(string id)
        {
             return costumerService.DeleteAsync(id);
        }
        #endregion


        #region Update function
        public Task<Costumer> Update(string id, BLCostumer newCostumer)
        {
            Costumer updatedCostumer = new Costumer();
            updatedCostumer.CostumerId = newCostumer.CostumerId;
            updatedCostumer.CostumerName = newCostumer.CostumerName;
            updatedCostumer.PhoneNumber = newCostumer.PhoneNumber;
            return costumerService.UpdateAsync(id, updatedCostumer);
        }
        #endregion

    }
}
