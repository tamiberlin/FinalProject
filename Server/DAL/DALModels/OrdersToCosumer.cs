using System;
using System.Collections.Generic;

namespace DAL.DALModels;

public partial class OrdersToCosumer
{
    public int OrderId { get; set; }

    public string CostumerId { get; set; } = null!;

    public string OrderType { get; set; } = null!;

    public int OrderCode { get; set; }

    public virtual Costumer Costumer { get; set; } = null!;
}
