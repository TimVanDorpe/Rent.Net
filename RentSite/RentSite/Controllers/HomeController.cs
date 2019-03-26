using RentSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            RentContext rc = new RentContext();
            Item item = rc.items.FirstOrDefault();

            return View();
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
        public ActionResult Share()
        {
            ViewBag.Message = "Your Share page.";

            return View();
        }
        public ActionResult Trade()
        {
            ViewBag.Message = "Your Trade page.";

            return View();
        }
        public ActionResult Rent()
        {
            ViewBag.Message = "Your Rent page.";

            return View();
        }
    }
}