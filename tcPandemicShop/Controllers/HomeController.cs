using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PandemicShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            ViewBag.Message = "FAQ";

            return View();
        }
        public ActionResult Manuals()
        {
            ViewBag.Message = "Download Instruction Manuals";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}