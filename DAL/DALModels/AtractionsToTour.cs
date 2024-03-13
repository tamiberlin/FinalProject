using System;
using System.Collections.Generic;

namespace DAL.DALModels1;

public partial class AtractionsToTour
{
    public int Attid { get; set; }

    public int AttractionCode { get; set; }

    public int TourCode { get; set; }

    public virtual Attraction AttractionCodeNavigation { get; set; } = null!;

    public virtual Tour TourCodeNavigation { get; set; } = null!;
}
