﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCenter.Domain.DTOs
{
    public class UserDTO : LoginDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

    }
}
