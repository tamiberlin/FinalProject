using System;
using System.Collections.Generic;

namespace DAL.DALModels1;

public partial class Room
{
    public int RoomId { get; set; }

    public int HouseCode { get; set; }

    public int RoomNumber { get; set; }

    public int NumOfBeds { get; set; }

    public bool? Terrace { get; set; }

    public virtual ICollection<DatesForRoom> DatesForRooms { get; set; } = new List<DatesForRoom>();

    public virtual Housing HouseCodeNavigation { get; set; } = null!;
}
