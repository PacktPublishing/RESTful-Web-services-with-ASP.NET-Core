﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PacktWebapp.Dtos
{
    public class CustomerCreateDto
    {
        [Required(ErrorMessage = "Please give the first name")]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        [Range(0,100)]
        public int Age { get; set; }
    }
}
