using System;
using Microsoft.EntityFrameworkCore;

namespace myMacVS.Models
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}
