using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLModels;

public class BLTour
{
    public int TourCode { get; set; }

    public string TourName { get; set; } = null!;

    public int FlightCode { get; set; }

    public int? HouseCode { get; set; }

    public bool IsOrgenized { get; set; }

    public decimal Price { get; set; }

    public int DestinationCode { get; set; }

    public virtual ICollection<AtractionsToTour> AtractionsToTours { get; set; } = new List<AtractionsToTour>();

    public virtual ICollection<Costumer> Costumers { get; set; } = new List<Costumer>();

    public virtual Destination DestinationCodeNavigation { get; set; } = null!;

    public virtual Flight FlightCodeNavigation { get; set; } = null!;

    public virtual Housing? HouseCodeNavigation { get; set; }
}
