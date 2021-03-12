using Store.Models;
using Store.Comparers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.Json;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        WatchContext db = new WatchContext();
        public ActionResult Index()
        {
            WatchOrdList listWO = new WatchOrdList();
            if (Session["goods"] != null)
            {
                listWO = JsonSerializer.Deserialize<WatchOrdList>(Session["goods"].ToString());
            }
            ViewBag.Badge = listWO.Counts;

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
        public PartialViewResult Location(string loc)
        {
            if (loc == null)
            {
                string value = HttpContext.Request.Cookies["location"]?.Value;
                ViewBag.Location = value;
            }
            else
            {
                HttpContext.Response.Cookies["location"].Value = loc;
                ViewBag.Location = loc;
            }
            return PartialView();
        }

        public int AddGood(int id)
        {
            WatchOrdList listWO = new WatchOrdList();
            if (Session["goods"] != null)
            {
                listWO = JsonSerializer.Deserialize<WatchOrdList>(Session["goods"].ToString());
            }

            Watch watch = db.Watches.Find(id);
            if (listWO.GetWO(watch) != null)
            {
                listWO.GetWO(watch).Quantity++;
            }
            else
                listWO.Add(new WatchOrder(watch));

            Session["goods"] = JsonSerializer.Serialize(listWO);
            return listWO.Counts;
        }
    }
}