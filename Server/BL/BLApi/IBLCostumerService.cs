using BL.BLModels;
using Common;


namespace BL.BLApi
{
    public interface IBLCostumerService
    {
            Task<List<BLCostumer>> GetAllAsync();
            Task<bool> CreateAsync(BLCostumer costumer);
            Task<bool> UpdateAsync(BLCostumer costumer);
            Task<bool> DeleteAsync(params string[] list);
        public List<BLCostumer> GetAll(BaseQueryParams queryParams);
    }
}
