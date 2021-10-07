using EventCenter.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCenter.Domain.DTOs
{
    public class EventPlaceDTO : EventPlaceBase
    {
        public int Id { get; set; }

        public LocationDTO Location { get; set; }
    }
}
