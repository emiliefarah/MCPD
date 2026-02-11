using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exerciceEFAdresse.Model;
using Microsoft.EntityFrameworkCore;

namespace exerciceEFAdresse.DbManager
{
    internal class AppDbContext : DbContext
    
    {
        public DbSet<Adresse> Adresse { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;database=adresse;uid=root;pwd=",
                ServerVersion.AutoDetect("server=localhost;database=adresse;uid=root;pwd=")

                );
        }
    }
}
