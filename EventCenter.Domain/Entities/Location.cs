using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCenter.Domain.Entities
{
    public class Location
    {
        public int Id { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public string Address { get; set; }

        public virtual IList<EventPlace> EventPlaces { get; set; }
    }
}
