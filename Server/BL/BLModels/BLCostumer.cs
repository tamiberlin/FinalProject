using BL.BLApi;
using Common;
using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLModels
{
    public class BLCostumer 
    {
        public string CostumerId { get; set; } = null!;

        public string CostumerName { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public int NumberOfPeople { get; set; }

        public string Email { get; set; } = null!;

        public virtual ICollection<DatesForRoom> DatesForRooms { get; set; } = new List<DatesForRoom>();

        public virtual ICollection<OrdersToCosumer> OrdersToCosumers { get; set; } = new List<OrdersToCosumer>();

    }
}
