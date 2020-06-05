using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tut13.Models
{
    public class Confectionary
    {
        [Key]
        public int IdConfecti { get; set; }
        public string Name { get; set; }
        public double PricePerlte { get; set; }
        public string Typ { get; set; }
    }
}
