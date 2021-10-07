using EventCenter.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace EventCenter.Infrastructure
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }


        public DbSet<EventPlace> EventCenters { get; set; }

        public DbSet<Location> Locations { get; set; }
    }
}
