using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Comparers
{
    public class BrandCompUp : IComparer<Watch>
    {
        public int Compare(Watch w1, Watch w2)
        {
            return string.Compare(w1.Brand, w2.Brand, true);
        }
    }
    public class BrandCompDown : IComparer<Watch>
    {
        public int Compare(Watch w1, Watch w2)
        {
            return string.Compare(w2.Brand, w1.Brand, true);
        }
    }
}