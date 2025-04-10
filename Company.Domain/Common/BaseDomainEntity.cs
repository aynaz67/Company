using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Domain.Common
{
    public abstract class BaseDomainEntity 
    {
        public int Id { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdateDate { get; set; } = DateTime.UtcNow;
    }
}
