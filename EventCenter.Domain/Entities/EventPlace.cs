using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCenter.Domain.Entities
{
    public class EventPlace
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey(nameof(Location))]

        public int LocationId { get; set; }

        public Location Location { get; set; }
    }
}
