using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BartendBuddy.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string Customer { get; set; }
        public string Drink { get; set; }
    }
}
