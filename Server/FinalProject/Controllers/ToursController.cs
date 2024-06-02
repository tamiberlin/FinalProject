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
public class ToursController : ControllerBase
{
    BLTourService tours;

    public ToursController(BLManager blManager)
    {
        this.tours = blManager.BLTour;
    }

    [EnableCors]
    [HttpGet]
    public List<BLTour> GetTours([FromQuery] BaseQueryParams queryParams)
    {
        return tours.GetAll(queryParams);
    }
}
