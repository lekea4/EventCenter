using EventCenter.Domain.Configurations.EntitiesRole;
using EventCenter.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace EventCenter.Infrastructure
{
    public class AppDBContext : IdentityDbContext<ApiUser>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.ApplyConfiguration(new EventPlaceConfiguration());
            builder.ApplyConfiguration(new LocationConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
        }


        public DbSet<EventPlace> EventCenters { get; set; }

        public DbSet<Location> Locations { get; set; }
    }
}
