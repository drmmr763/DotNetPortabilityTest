using System;
using Microsoft.EntityFrameworkCore;

namespace EfCoreBasic.Entities
{
    public class GardenContext : DbContext
    {
        public DbSet<Garden> Gardens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433; Database=GardenDb1;User=sa; Password=<YourStrong@Passw0rd>");
    }
}
