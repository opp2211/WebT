using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Comparers
{
    public class PriceCompUp : IComparer<Watch>
    {
        public int Compare(Watch w1, Watch w2)
        {
            if (w1.Price > w2.Price)
                return -1;
            else if (w1.Price < w2.Price)
                return 1;
            else
                return 0;
        }
    }
    public class PriceCompDown : IComparer<Watch>
    {
        public int Compare(Watch w1, Watch w2)
        {
            if (w1.Price < w2.Price)
                return -1;
            else if (w1.Price > w2.Price)
                return 1;
            else
                return 0;
        }
    }
}