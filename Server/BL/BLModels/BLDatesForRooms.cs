using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLModels;

public class BLDatesForRooms
{
    public int DateId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int RoomCode { get; set; }

    public string CostumerCode { get; set; } = null!;

    public virtual Costumer CostumerCodeNavigation { get; set; } = null!;

    public virtual Room RoomCodeNavigation { get; set; } = null!;
}
