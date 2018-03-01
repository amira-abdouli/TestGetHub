using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestGetHub.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //the frist commit
            //the second commit
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "hi my name is aiman";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "the second message";

            return View();
        }
    }
}