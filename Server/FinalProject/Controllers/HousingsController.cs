using BL;
using BL.BLImplementation;
using BL.BLModels;
using Common;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HousingsController : ControllerBase
{
    BLHousingService housings;

    public HousingsController(BLManager blManager)
    {
        this.housings = blManager.BLHousing;
    }

    [EnableCors]
    [HttpGet]
    public List<BLHousing> GetHousings([FromQuery] BaseQueryParams queryParams)
    {
        return housings.GetAll(queryParams);
    }
}
