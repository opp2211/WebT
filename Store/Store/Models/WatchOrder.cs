using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Models
{
    public class WatchOrder
    {
        public WatchOrder(Watch watch)
        {
            Watch = watch;
            Quantity = 1;
        }
        public Watch Watch { get; set; }
        public int Quantity { get; set; }
    }
}