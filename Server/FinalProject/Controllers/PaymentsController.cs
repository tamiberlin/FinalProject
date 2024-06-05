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
public class PaymentsController : ControllerBase
{
    BLPaymentService payments;
    public PaymentsController(BLManager BlManager)
    {
        payments = BlManager.BLPayment;
    }

    [EnableCors]
    [HttpGet]
    public List<BLPayment> GetPayments([FromQuery] BaseQueryParams queryParams)
    {
        return payments.GetAll(queryParams);
    }
}
