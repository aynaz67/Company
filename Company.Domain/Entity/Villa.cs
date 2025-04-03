using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Display(Name ="Create Date")]
        public required DateTime CreateDate { get; set; }
        [Display(Name ="Update Data")]
        public DateTime? UpdateDate { get; set; }
    }
}
