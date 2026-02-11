using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using demo_EntityFramework.Model;

namespace demo_EntityFramework.DbManager
{
    internal class AppDbContext: DbContext
    {

        public DbSet<Personne> Personne { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                
                "server=localhost;database=ado;uid=root;pwd=",
               ServerVersion.AutoDetect ("server=localhost;database=ado;uid=root;pwd=")

                );
        }



    }
}
