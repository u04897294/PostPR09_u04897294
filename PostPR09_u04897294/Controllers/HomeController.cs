using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace PostPR09_u04897294.Controllers
{
    public class HomeController : Controller
    {
    

        public ActionResult AddData()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ShowData()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}