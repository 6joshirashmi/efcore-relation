using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;
using Microsoft.EntityFrameworkCore;

namespace efcorejoin.Infra
{
    public class Efcoredb:DbContext
    {
        public Efcoredb(){

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MAHAAN-BHARAT\\MSSQLSERVERS;database=efcorejoin;TrustServerCertificate=true; user id=sa; password=1234;");
        }

          public  DbSet<Customer> customers{get; set;}
          public DbSet<Order> orders{get; set;}
          public DbSet<Payment> payments{get;set;}

          
    }
}