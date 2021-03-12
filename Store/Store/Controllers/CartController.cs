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
    public class CartController : Controller
    {
        WatchContext db = new WatchContext();
        public ActionResult Index()
        {
            WatchOrdList listWO = new WatchOrdList();
            if (Session["goods"] != null)
            {
                listWO = JsonSerializer.Deserialize<WatchOrdList>(Session["goods"].ToString());
            }

            return View(listWO);
        }
        public ActionResult UpdateQuantt(int id, int quantt)
        {
            WatchOrdList listWO = new WatchOrdList();
            if (Session["goods"] != null)
            {
                listWO = JsonSerializer.Deserialize<WatchOrdList>(Session["goods"].ToString());
            }
            WatchOrder WO = listWO.GetWObyID(id);

            WO.Quantity += quantt;
            if (WO.Quantity == 0)
                listWO.Remove(WO);
                

            Session["goods"] = JsonSerializer.Serialize(listWO);
            return View("Index", listWO);
        }
    }
}