using System;
using System.Collections.Generic;

namespace DAL.DALModels;

public partial class Housing
{
    public int HouseId { get; set; }

    public string HouseName { get; set; } = null!;

    public int AddressCode { get; set; }

    public string Cosher { get; set; } = null!;

    public decimal PricePerBed { get; set; }

    public int NumOfRooms { get; set; }

    public string Email { get; set; } = null!;

    public bool IsHotel { get; set; }

    public virtual Destination AddressCodeNavigation { get; set; } = null!;

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();

    public virtual ICollection<Tour> Tours { get; set; } = new List<Tour>();
}
