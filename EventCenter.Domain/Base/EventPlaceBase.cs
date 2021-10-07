using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCenter.Domain.Base
{
    public class EventPlaceBase
    {
        [Required]
        public string Name { get; set; }

        public int LocationId { get; set; }

    }
}
