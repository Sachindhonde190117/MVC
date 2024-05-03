using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HelpersController : Controller
    {
        // GET: Helpers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Post(int? id)
        {
            if (id == null)
            {
                ViewBag.Message = "null";
            }
            else
            {
                ViewBag.Message = "Hi...............";
            }
            return View("Index");
        } 
    }
}