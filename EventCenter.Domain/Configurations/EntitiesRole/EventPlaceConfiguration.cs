using EventCenter.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCenter.Domain.Configurations.EntitiesRole
{
    public class EventPlaceConfiguration : IEntityTypeConfiguration<EventPlace>
    {
        public void Configure(EntityTypeBuilder<EventPlace> builder)
        {
            builder.HasData(
                new EventPlace
                {
                    Id = 4,
                    Name = "Arewa Event Center",
                    Address = "Fagba, Iju, Lagos",
                    LocationId = 1
  
                }
            );
        }
    }
}
