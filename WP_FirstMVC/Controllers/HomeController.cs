using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WP_FirstMVC.Models;

namespace WP_FirstMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var context = new DataContext();
            var owner = context.TB_CORE_OWNER.OrderByDescending(x => x.OWNER_ID).Take(5).ToList();
            return View(owner);




            //return View();
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