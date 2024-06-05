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
public class RoomsController : ControllerBase
{
    BLRoomService rooms;
    public RoomsController(BLManager BlManager)
    {
        rooms = BlManager.BLRoom;
    }

    [EnableCors]
    [HttpGet]
    public List<BLRoom> GetRooms([FromQuery] BaseQueryParams queryParams)
    {
        return rooms.GetAll(queryParams);
    }
}
