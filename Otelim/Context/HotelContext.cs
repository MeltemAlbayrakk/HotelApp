using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Otelim.Models;
using System.Text.RegularExpressions;

namespace Otelim.Context
{
    public class HotelContext : DbContext
    {
        public HotelContext()
        {

        }


        public HotelContext(DbContextOptions<HotelContext> options)
             : base(options)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = HotelApp; Trusted_Connection = True; MultipleActiveResultSets = true; Encrypt = false");
        }
      
        public virtual DbSet<Hotel>? Hotels { get; set; }
        public virtual DbSet<User>? Users { get; set; }
        public virtual DbSet<Theme>? Themes { get; set; }
        public virtual DbSet<Reservation>? Reservations { get; set; }
        public virtual DbSet<PaymentType>? PaymentTypes { get; set; }

       




    }

}
