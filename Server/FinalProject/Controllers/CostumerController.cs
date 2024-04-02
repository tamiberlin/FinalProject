using BL;
using BL.BLImplementation;
using BL.BLModels;
using Common;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CostumerController : ControllerBase
    {
        BLCostumerService costumers;
        
        public CostumerController(BLManager BlManager)
        {
            costumers = BlManager.BLCostumer;
        }

        [EnableCors]
        [HttpGet]
        public List<BLCostumer> GetCostumers([FromQuery] BaseQueryParams queryParams)
        {
            return costumers.GetAll(queryParams);
        }
    }
}
