using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public int OrderID { get; set; }
        public int WatchId { get; set; }
        public int Quantity { get; set; }
    }
}