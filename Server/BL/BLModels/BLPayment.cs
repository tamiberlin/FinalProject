using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLModels;

public class BLPayment
{
    public int PaymentId { get; set; }

    public string OwnerId { get; set; } = null!;

    public string CreditCardNumber { get; set; } = null!;

    public DateTime Validity { get; set; }

    public int Cvv { get; set; }
}
