using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cracker.Data
{
    public class CrackerDbContext:DbContext
    {
        protected override void OnConfiguring(
           DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=PP-PC\SQLEXPRESS;Database=Cakes;Integrated Security=True;").UseLazyLoadingProxies();
        }
    }
}
