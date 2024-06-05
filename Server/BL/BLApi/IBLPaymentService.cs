using BL.BLModels;
using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLApi;

public interface IBLPaymentService: IBLService<BLPayment, Payment>
{
}
