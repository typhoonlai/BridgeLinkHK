using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PandemicShop.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult CategoryList()
        {
            return View();
        }

        public ActionResult BagDetails()
        {
            return View();
        }

        public ActionResult Bag_1010()
        {
            return View();
        }
        public ActionResult Bag_105()
        {
            return View();
        }
    }
}