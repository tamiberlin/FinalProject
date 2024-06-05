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
public class AtractionsToToursController : ControllerBase
{
    BLAtractionsToTourService atractionsToTour;
    public AtractionsToToursController(BLManager BlManager)
    {
        this.atractionsToTour = BlManager.BLAtractionsToTours;
    }

    [EnableCors]
    [HttpGet]
    public List<BLAtractionsToTour> GetATTs([FromQuery] BaseQueryParams queryParams)
    {
        return atractionsToTour.GetAll(queryParams);
    }
}
