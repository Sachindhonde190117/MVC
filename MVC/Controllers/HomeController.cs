using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    [RoutePrefix("myhome")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("myAbout")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public string GetMessage1()
        {
            return "GetMessage1 " + GetContact();
        }

        public string GetMessage()
        {
            return "GetMessage " +  GetContact();
        }

        [NonAction]
        public string GetContact()
        {
            return "Hi...";
        }
    }
}