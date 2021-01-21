using Store.Models;
using Store.Comparers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        WatchContext db = new WatchContext();
        public ActionResult Index()
        {
            return View(db.Watches.ToList());
        }

        public PartialViewResult GoodsSection(int sort, int price_from, int price_to, int gender, int type)
        {
            var watches = db.Watches.ToList();

            switch (sort)
            {
                case 1:
                    watches.Sort(new BrandCompUp());
                    break;
                case 2:
                    watches.Sort(new BrandCompDown());
                    break;
                case 3:
                    watches.Sort(new PriceCompUp());
                    break;
                case 4:
                    watches.Sort(new PriceCompDown());
                    break;
            }
            for(int i = 0; i < watches.Count; i++)
            {
                if (!(watches[i].Price > price_from && watches[i].Price < price_to))
                {
                    watches.RemoveAt(i);
                    i--;
                }
            }
            if (gender != 0)
            {
                for (int i = 0; i < watches.Count; i++)
                {
                    if (watches[i].Gender != gender)
                    {
                        watches.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (type != 0)
            {
                for (int i = 0; i < watches.Count; i++)
                {
                    if (watches[i].Type != type)
                    {
                        watches.RemoveAt(i);
                        i--;
                    }
                }
            }

            return PartialView(watches);
        }
    }
}