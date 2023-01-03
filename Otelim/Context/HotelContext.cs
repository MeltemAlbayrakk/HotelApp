using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Otelim.Models;
using System.Net;
using System.Reflection.Emit;
using System.Text.RegularExpressions;

namespace Otelim.Context
{
    public class HotelContext : DbContext
    {
        public HotelContext()
        {

        }


        public HotelContext(DbContextOptions<HotelContext> options) : base(options){ }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = HotelApp; Trusted_Connection = True; MultipleActiveResultSets = true; Encrypt = false");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            
        }

        public  DbSet<Hotel>? Hotels { get; set; }
        public  DbSet<User>? Users { get; set; }
        public  DbSet<Theme>? Themes { get; set; }
        public  DbSet<Reservation>? Reservations { get; set; }
        public  DbSet<PaymentType>? PaymentTypes { get; set; }

       




    }

}
