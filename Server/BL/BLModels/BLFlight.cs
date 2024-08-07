﻿using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLModels;

public class BLFlight
{
    public int FlightId { get; set; }

    public int DepartureCode { get; set; }

    public int DestinationCode { get; set; }

    public DateTime Date { get; set; }

    public TimeSpan LeavingTime { get; set; }

    public TimeSpan ArrivalTime { get; set; }

    public string Company { get; set; } = null!;

    public double Price { get; set; }

    public virtual Destination DepartureCodeNavigation { get; set; } = null!;

    public virtual Destination DestinationCodeNavigation { get; set; } = null!;

    public virtual ICollection<Tour> Tours { get; set; } = new List<Tour>();
}
