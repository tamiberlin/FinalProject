using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLModels;

public class BLAtractionsToTour
{
    public int Attid { get; set; }

    public int AttractionCode { get; set; }

    public int TourCode { get; set; }

    public virtual Attraction AttractionCodeNavigation { get; set; } = null!;

    public virtual Tour TourCodeNavigation { get; set; } = null!;
}
