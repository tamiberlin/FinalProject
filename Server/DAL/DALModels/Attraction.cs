using System;
using System.Collections.Generic;

namespace DAL.DALModels;

public partial class Attraction
{
    public int AttractionId { get; set; }

    public string AttractionName { get; set; } = null!;

    public int AddressCode { get; set; }

    public TimeSpan? DurationOfActivity { get; set; }

    public decimal PricePerTicket { get; set; }

    public virtual Destination AddressCodeNavigation { get; set; } = null!;

    public virtual ICollection<AtractionsToTour> AtractionsToTours { get; set; } = new List<AtractionsToTour>();
}
