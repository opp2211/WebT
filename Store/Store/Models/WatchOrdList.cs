using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Models
{
    public class WatchOrdList : List<WatchOrder>
    {
        public int Counts
        {
            get
            {
                int count = 0;
                foreach (var item in this)
                {
                    count += item.Quantity;
                }
                return count;
            }
        }
        public WatchOrder GetWO(Watch watch)
        {
            foreach (var item in this)
            {
                if (watch == item.Watch)
                    return item;
            }
            return null;
        }
        public WatchOrder GetWObyID(int Id)
        {
            foreach (var item in this)
            {
                if (Id == item.Watch.Id)
                    return item;
            }
            return null;
        }
    }
}