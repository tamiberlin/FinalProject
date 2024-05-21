using System;
using System.Collections.Generic;

namespace DAL.DALModels;

public partial class DatesForRoom
{
    public int DateId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int RoomCode { get; set; }

    public string CostumerCode { get; set; } = null!;

    public virtual Costumer CostumerCodeNavigation { get; set; } = null!;

    public virtual Room RoomCodeNavigation { get; set; } = null!;
}
