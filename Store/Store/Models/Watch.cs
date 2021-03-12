using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Models
{
    public class Watch
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Descr { get; set; }
        public int Price { get; set; }
        public int Gender { get; set; }
        public int Type { get; set; }
        public string Img { get; set; }

        public static bool operator ==(Watch w1, Watch w2)
        {
            return w1.Id == w2.Id;
        }
        public static bool operator !=(Watch w1, Watch w2)
        {
            return w1.Id != w2.Id;
        }
    }
}
