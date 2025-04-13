using Company.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Domain.Entity
{
    public class User : BaseDomainEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public List<string> Roles { get; set; }

        public string Password { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
