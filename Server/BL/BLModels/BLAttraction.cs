using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLModels;

public class BLAttraction
{
    public int AttractionId { get; set; }

    public string AttractionName { get; set; } = null!;

    public int AddressCode { get; set; }

    public TimeSpan? DurationOfActivity { get; set; }

    public decimal PricePerTicket { get; set; }

    public virtual Destination AddressCodeNavigation { get; set; } = null!;

    public virtual ICollection<AtractionsToTour> AtractionsToTours { get; set; } = new List<AtractionsToTour>();
}
