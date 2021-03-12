using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Location { get; set; }
        public DateTime DateTime { get; set; }
    }
}