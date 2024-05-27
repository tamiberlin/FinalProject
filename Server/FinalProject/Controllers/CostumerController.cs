using BL;
using BL.BLImplementation;
using BL.BLModels;
using Common;
using DAL.DALModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]

public class CostumerController : ControllerBase
{
    BLCostumerService costumers;

    public CostumerController(BLManager BlManager)
    {
        this.costumers = BlManager.BLCostumer;
    }

    [EnableCors]
    [HttpGet]
    public List<BLCostumer> GetCostumers([FromQuery] BaseQueryParams queryParams)
    {
        return costumers.GetAll(queryParams);
    }

    [EnableCors]
    [HttpPost]
    public Costumer CreateCostumer([FromBody] BLCostumer costumer)
    {
        return costumers.Create(costumer).Result;
    }

    [EnableCors]
    [HttpDelete("{id}")]
    public Costumer DeleteCostumer(int id)
    {
        return costumers.Delete(id.ToString()).Result;
    }

    [EnableCors]
    [HttpPut("{id}")]
    public Costumer Updatecostumer(int id,[FromBody] BLCostumer costumer)
    {
        return costumers.Update(id.ToString(), costumer).Result;
    }
}
