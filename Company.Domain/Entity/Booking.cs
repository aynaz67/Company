using Company.Domain.Common;
using Company.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Domain.Entity
{
    public class Booking : BaseDomainEntity
    {
        public int Id { get; set; }


        public int CustomerId { get; set; }


        public int VillaId { get; set; }


        public DateTime BookingDateTime { get; set; }


        public TimeSpan StartTime { get; set; }


        public BookingStatus Status { get; set; }

        public User Customer { get; set; }

        public Villa villa { get; set; }
    }
}
