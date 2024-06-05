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
public class DatesForRoomsController : ControllerBase
{
    BLDatesForRoomsService datesForRooms;
    public DatesForRoomsController(BLManager BlManager)
    {
        datesForRooms = BlManager.BLDatesForRooms;
    }

    [EnableCors]
    [HttpGet]
    public List<BLDatesForRooms> GetDatesForRooms([FromQuery] BaseQueryParams queryParams)
    {
        return datesForRooms.GetAll(queryParams);
    }
}
