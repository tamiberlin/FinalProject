using System;
using System.Collections.Generic;

namespace DAL.DALModels1;

public partial class Costumer
{
    public string CostumerId { get; set; } = null!;

    public string CostumerName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public int NumberOfPeople { get; set; }

    public int TourCode { get; set; }

    public int PaymentCode { get; set; }

    public virtual ICollection<DatesForRoom> DatesForRooms { get; set; } = new List<DatesForRoom>();

    public virtual Payment PaymentCodeNavigation { get; set; } = null!;

    public virtual Tour TourCodeNavigation { get; set; } = null!;
}
