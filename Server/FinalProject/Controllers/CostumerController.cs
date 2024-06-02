using BL;
using BL.BLImplementation;
using BL.BLModels;
using Common;
using DAL.DALModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


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
    [HttpGet("{id}")]
    public ActionResult<BLCostumer> GetCostumerById(int id)
    {
        BLCostumer costumer =  costumers.GetById(id.ToString());
        if(costumer.CostumerName != null)
        {
            return costumer;
        }
        return NotFound();
    }

    [EnableCors]
    [HttpPost]
    public Costumer CreateCostumer([FromBody] BLCostumer costumer)
    {
        return costumers.Create(costumer).Result;
    }

    [EnableCors]
    [HttpDelete("{id}")]
    public ActionResult<Costumer> DeleteCostumer(int id)
    {
        Costumer delete =  costumers.Delete(id.ToString()).Result;
        if(delete != null)
        {
            return delete;
        }
        return NotFound();
    }

    [EnableCors]
    [HttpPut("{id}")]
    public ActionResult<Costumer> Updatecostumer(int id,[FromBody] BLCostumer costumer)
    {
        Costumer Update  = costumers.Update(id.ToString(), costumer).Result;
        if (Update != null)
        {
            return Update;
        }
        return NotFound();
    }
}
