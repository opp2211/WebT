﻿using Store.Models;
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
            ViewBag.Watches = db.Watches.ToList();
            return View();
        }

        public PartialViewResult GoodsSection()
        {
            return PartialView();
        }
    }
}