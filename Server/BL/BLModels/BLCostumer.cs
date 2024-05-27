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

        public int TourCode { get; set; }

        public int PaymentCode { get; set; }

        //public virtual ICollection<DatesForRoom> DatesForRooms { get; set; } = new List<DatesForRoom>();

        //public virtual Payment PaymentCodeNavigation { get; set; } = null!;

        //public virtual Tour TourCodeNavigation { get; set; } = null!;
    }
}
