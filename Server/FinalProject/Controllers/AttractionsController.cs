﻿using BL;
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

public class AttractionsController:ControllerBase
{
    BLAttractionService attractions;

    public AttractionsController(BLManager BlManager)
    {
        this.attractions = BlManager.BLAttraction;
    }

    [EnableCors]
    [HttpGet]
    public List<BLAttraction> GetAttractions([FromQuery] BaseQueryParams queryParams)
    {
        return attractions.GetAll(queryParams);
    }
}
