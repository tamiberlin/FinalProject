using System;
using System.Collections.Generic;

namespace DAL.DALModels;

public partial class Payment
{
    public int PaymentId { get; set; }

    public string OwnerId { get; set; } = null!;

    public string CreditCardNumber { get; set; } = null!;

    public DateTime Validity { get; set; }

    public int Cvv { get; set; }

    public virtual ICollection<Costumer> Costumers { get; set; } = new List<Costumer>();
}
