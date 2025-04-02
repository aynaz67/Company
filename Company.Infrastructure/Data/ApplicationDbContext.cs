using Company.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Infrastructure.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        
        }

        public DbSet<Villa> Villas { get; set; }
        //initilising tables
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData( 
            new Villa 
            { 
                Id=1,
                Name="Aynaz",
                Description="It's me",
                CreateDate = DateTime.Now,
                
            },
              new Villa
              {
                  Id = 2,
                  Name = "Elnaz",
                  Description = "It's my sister",
                  CreateDate = DateTime.Now,
              }
           );
  
        }
    }
}
