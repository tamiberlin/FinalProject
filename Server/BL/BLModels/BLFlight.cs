using DAL.DALModels;
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
    public string DepartureCity { get; set; }
    public string DepartureCountry { get; set; }
    public int DestinationCode { get; set; }
    public string DestinationCity { get; set; }
    public string DestinationCountry { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan LeavingTime { get; set; }
    public TimeSpan ArrivalTime { get; set; }
    public string Company { get; set; }
    public double Price { get; set; }
    public int AmountOfSeats { get; set; }
    public int BookedSeats { get; set; }
}
