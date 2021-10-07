using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCenter.Domain.Base
{
    public class LocationBase
    {
        [Required]
        public string Country { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
