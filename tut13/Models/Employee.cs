using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tut13.Models
{
    public class Employee
    {
        [Key]
        public int IdEmpl { get; set; }
        public string Name { get; set; }
        public string Surna{ get; set; }
    }
}
