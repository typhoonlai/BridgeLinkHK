using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyServices.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult AIAccounting()
        {
            ViewBag.Title = "博翹人工智能會計";

            return View();
        }
        public ActionResult WebDesignHosting()
        {
            ViewBag.Title = "網站設計和管理";

            return View();
        }
        public ActionResult GovernmentSubsidy()
        {
            ViewBag.Title = "政府資助計劃";

            return View();
        }
        public ActionResult LogoDesign()
        {
            ViewBag.Title = "標誌設計";

            return View();
        }
        public ActionResult AccountServices()
        {
            ViewBag.Title = "註册公司及核數服務";

            return View();
        }
    }
}