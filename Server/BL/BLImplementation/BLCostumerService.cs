using BL.BLApi;
using BL.BLModels;
using Common;
using DAL;
using DAL.DALImplementation;
using DAL.DALModels;

namespace BL.BLImplementation
{
    public class BLCostumerService : IBLCostumerService
    {
        DALCostumerService costumerService;
        public BLCostumerService(DALManager costumerService)
        {
            this.costumerService = costumerService.Costumers;
        }
        public async Task<List<BLCostumer>> GetAllAsync()
        {
            List<Costumer> pagedCostumers = await costumerService.GetAllAsync();
            List<BLCostumer> usersList = new List<BLCostumer>();
            foreach (var costumer in pagedCostumers)
            {
                BLCostumer newCostumer = new BLCostumer();
                newCostumer.CostumerName = costumer.CostumerName;
                usersList.Add(newCostumer);
            }
            return usersList;
        }
   




        public Task<bool> CreateAsync(BLCostumer costumer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(BLCostumer costumer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(params string[] list)
        {
            throw new NotImplementedException();
        }

        //public List<BLCostumer> GetAll(BaseQueryParams queryParams)
        //{
        //    throw new NotImplementedException();
        //}


    }
}
