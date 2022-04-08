using System;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class ReCapDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=ReCapDB;User=sa;Password=10203040Aa;");
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars{ get; set; }
        public DbSet<Color> Colors{ get; set; }
    }
}
