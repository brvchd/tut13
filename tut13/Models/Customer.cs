﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tut13.Models
{
    public class Customer
    {
        [Key]
        public int IdClient { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
