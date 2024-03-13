using System;
using System.Collections.Generic;

namespace DAL.DALModels1;

public partial class Destination
{
    public int DestinationId { get; set; }

    public string CountryName { get; set; } = null!;

    public string CityName { get; set; } = null!;

    public virtual ICollection<Attraction> Attractions { get; set; } = new List<Attraction>();

    public virtual ICollection<Flight> FlightDepartureCodeNavigations { get; set; } = new List<Flight>();

    public virtual ICollection<Flight> FlightDestinationCodeNavigations { get; set; } = new List<Flight>();

    public virtual ICollection<Housing> Housings { get; set; } = new List<Housing>();

    public virtual ICollection<Tour> Tours { get; set; } = new List<Tour>();
}
