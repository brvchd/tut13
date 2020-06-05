using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tut13.Models
{
    public class Order
    {
        [Key]
        public int IdOrder { get; set; }
        public DateTime DateAccepted { get; set; }
        public DateTime DateFinished { get; set; }
        public string Notes { get; set; }
        public int IdEmployee { get; set; }
        [ForeignKey("IdEmployee")]
        public Employee Employee { get; set; }
        public int IdClient { get; set; }
        [ForeignKey("IdClient")]
        public Customer Client { get; set; }
    }
}
