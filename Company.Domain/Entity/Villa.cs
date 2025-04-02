using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Company.Domain.Entity
{
    public class Villa
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        //log
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
