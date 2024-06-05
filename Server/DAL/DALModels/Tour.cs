using System;
using System.Collections.Generic;

namespace DAL.DALModels;

public partial class Tour
{
    public int TourCode { get; set; }

    public string TourName { get; set; } = null!;

    public int FlightCode { get; set; }

    public int HouseCode { get; set; }

    public bool IsOrgenized { get; set; }

    public decimal Price { get; set; }

    public int DestinationCode { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public virtual ICollection<AtractionsToTour> AtractionsToTours { get; set; } = new List<AtractionsToTour>();

    public virtual Destination DestinationCodeNavigation { get; set; } = null!;

    public virtual Flight FlightCodeNavigation { get; set; } = null!;

    public virtual Housing HouseCodeNavigation { get; set; } = null!;
}
