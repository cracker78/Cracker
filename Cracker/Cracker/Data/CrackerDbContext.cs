using Cracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cracker.Data
{
    public class CrackerDbContext:DbContext
    {
        public DbSet<BeerHouse> BeerHouses { get; set; }
        public DbSet<Beer> Beers { get; set; }

        protected override void OnConfiguring(
           DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=PP-PC\SQLEXPRESS;Database=BeerHouse;Integrated Security=True;").UseLazyLoadingProxies();
        }
    }
}
