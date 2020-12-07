using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BakedInHeaven.API.Model;
using BakedInHeaven.Model;

namespace BakedInHeaven.API.Context
{
    public class BakeryDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=bakerydb;User Id=postgres;Password=kavyamol;Pooling=true;");
    }
}







