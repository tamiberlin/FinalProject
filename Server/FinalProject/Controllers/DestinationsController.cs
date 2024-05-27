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

public class DestinationsController:ControllerBase
{
    BLDestinationService destinations;

    public DestinationsController(BLManager BlManager)
    {
        destinations = BlManager.BLDestination;
    }

    [EnableCors]
    [HttpGet]
    public List<BLDestination> GetDestinations([FromQuery] BaseQueryParams queryParams)
    {
        return destinations.GetAll(queryParams);
    }
    
}
