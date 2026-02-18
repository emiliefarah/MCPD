using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExoHotel.Model;
using Microsoft.EntityFrameworkCore;

namespace ExoHotel.DbManager
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Client> Client { get; set; }
        public DbSet<Chambre> Chambre { get; set; }
        public DbSet<Reservation>Reservation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
          
                 "server=localhost;database=hotel;uid=root;pwd=",
                ServerVersion.AutoDetect("server=localhost;database=hotel;uid=root;pwd=")
                );
        }


    }

}
