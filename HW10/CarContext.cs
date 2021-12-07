using System;
using Microsoft.EntityFrameworkCore;

namespace HW10
{
    internal class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=car.db");
        }
    }
}