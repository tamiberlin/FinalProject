using BL.BLApi;
using BL.BLModels;
using Common;
using DAL.DALApi;
using DAL.DALImplementation;
using DAL.DALModels1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLImplementation
{
    public class BLCostumerService : IBLCostumerService
    {
        CostumerService costumerService;
        public BLCostumerService(CostumerService costumerService)
        {
            this.costumerService = costumerService;
        }

        public List<BLCostumer> GetCostumers(BaseQueryParams queryParams)
        {
            Task<PagedList<Costumer>> pagedCostumers = costumerService.GetAllAsync(queryParams);
            List<BLCostumer> usersList = new List<BLCostumer>();
            foreach (var costumer in pagedCostumers.Result)
            {
                BLCostumer newCostumer = new BLCostumer();
                newCostumer.CostumerName = costumer.CostumerName;
                usersList.Add(newCostumer);
            }
            return usersList;
        }

        public List<BLCostumer> GetAll(BaseQueryParams queryParams)
        {
            Task<PagedList<Costumer>> pagedCostumers = costumerService.GetAllAsync(queryParams);
            List<BLCostumer> usersList = new List<BLCostumer>();
            foreach (var costumer in pagedCostumers.Result)
            {
                BLCostumer newCostumer = new BLCostumer();
                newCostumer.CostumerName = costumer.CostumerName;
                usersList.Add(newCostumer);
            }
            return usersList;
        }

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
