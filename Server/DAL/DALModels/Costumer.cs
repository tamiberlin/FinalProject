using System;
using System.Collections.Generic;

namespace DAL.DALModels;

public partial class Costumer
{
    public string CostumerId { get; set; } = null!;

    public string CostumerName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public int NumberOfPeople { get; set; }

    public string Email { get; set; } = null!;

    public virtual ICollection<DatesForRoom> DatesForRooms { get; set; } = new List<DatesForRoom>();

    public virtual ICollection<OrdersToCosumer> OrdersToCosumers { get; set; } = new List<OrdersToCosumer>();
}
