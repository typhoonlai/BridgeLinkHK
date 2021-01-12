using GraceFellowShipRetreat2020.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GraceFellowShipRetreat2020.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            BlogRepository blogRepo = new BlogRepository();
            
            return View(blogRepo.GetAllArticles());
        }
    }
}