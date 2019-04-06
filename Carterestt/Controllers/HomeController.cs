<<<<<<< HEAD
﻿using Data;
using System;
=======
﻿using System;
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carterestt.Controllers
{
    public class HomeController : Controller
    {
<<<<<<< HEAD
        private CarContext db = new CarContext();

        public ActionResult Index()
        {

            return View(db.Brands.ToList());
=======
        public ActionResult Index()
        {
            return View();
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}