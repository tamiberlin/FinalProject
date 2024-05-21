using BL.BLApi;
using BL.BLModels;
using Common;
using DAL.DALImplementation;
using DAL.DALModels1;

namespace BL.BLImplementation
{
    public class BLCostumerService : IBLCostumerService
    {
        DALCostumerService costumerService;
        public BLCostumerService(DALCostumerService costumerService)
        {
            this.costumerService = costumerService;
        }

        /*     public List<BLCostumer> GetCostumers(BaseQueryParams queryParams)
             {
                 Task<List<Costumer>> pagedCostumers = costumerService.GetAllAsync(queryParams);
                 List<BLCostumer> usersList = new List<BLCostumer>();
                 foreach (var costumer in pagedCostumers.Result)
                 {
                     BLCostumer newCostumer = new BLCostumer();
                     newCostumer.CostumerName = costumer.CostumerName;
                     usersList.Add(newCostumer);
                 }
                 return usersList;
             }*/
        /*     public async Task<List<FlightDTO>> GetAllAsync()
             {
                 List<Flight> flights = await _flightRepo.GetAllAsync();
                 List<FlightDTO> flightDTOs = new List<FlightDTO>();
                 flights.ForEach(flight => {
                     FlightDTO f = _mapper.Map<Flight, FlightDTO>(flight);
                     flightDTOs.Add(f);
                 });
                 return flightDTOs;
             }*/
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
        /*  public Task<List<BLCostumer>> GetAllAsync()
          {
              throw new NotImplementedException();
          }*/

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

        public List<BLCostumer> GetAll(BaseQueryParams queryParams)
        {
            throw new NotImplementedException();
        }


    }
}
