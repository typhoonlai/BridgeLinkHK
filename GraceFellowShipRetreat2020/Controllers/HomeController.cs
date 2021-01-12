using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GraceFellowShipRetreat2020.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Singapore()
        {
            return View();
        }

        public ActionResult SingaporeImmigration()
        {
            

            return View();
        }
        public ActionResult SingaporeVideos()
        {


            return View();
        }
        public ActionResult WhySingapore()
        {


            return View();
        }
        public ActionResult SPRegistration()
        {


            return View();
        }
        public ActionResult SPSchools()
        {


            return View();
        }
        public ActionResult SPSchoolCompare()
        {


            return View();
        }
        public ActionResult Landing()
        {


            return View();
        }
        public ActionResult Education()
        {


            return View();
        }
        public ActionResult SPAEIS()
        {


            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}