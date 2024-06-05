using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLModels;

public class BLRoom
{
    public int RoomId { get; set; }

    public int HouseCode { get; set; }

    public int RoomNumber { get; set; }

    public int NumOfBeds { get; set; }

    public bool? Terrace { get; set; }

    public virtual ICollection<DatesForRoom> DatesForRooms { get; set; } = new List<DatesForRoom>();

    public virtual Housing HouseCodeNavigation { get; set; } = null!;
}
