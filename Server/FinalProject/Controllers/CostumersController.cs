using BL.BLModels;
using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CostumersController : ControllerBase
    {
        BLCostumer blCostumer;
        [HttpGet]
        public List<BLCostumer> GetCostumers([FromQuery] BaseQueryParams queryParams)
        {
            return blCostumer.GetCostumers(queryParams);
        }
    }
}
