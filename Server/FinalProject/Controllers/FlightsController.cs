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
public class FlightsController : ControllerBase
{
    BLFlightService flights;
    public FlightsController(BLManager BlManager)
    {
        flights = BlManager.BLFlight;
    }

    [EnableCors]
    [HttpGet]
    public List<BLFlight> GetFlights([FromQuery] BaseQueryParams queryParams) 
    {
        return flights.GetAll(queryParams);
    }
}
