using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class DatapassingController : Controller
    {
        // GET: Datapassing
        public ActionResult Index()
        {
            ViewBag.Message = "Hello I ma ViewBag";
            ViewBag.Title = "Index ViewBag";
            ViewBag.Roll = 100;
            List<string> list = new List<string>();
            list.Add("Pravin");
            list.Add("Sham");
            list.Add("Pooja");
            ViewBag.List = list;
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("Sagar", 100);
            dictionary.Add("Amit", 101);

            Dictionary<int, int> keyValues = new Dictionary<int, int>();
            keyValues.Add(1, 100);
            keyValues.Add(2, 98);
            keyValues.Add(3, 80);

            int value = dictionary["Sagar"];
            ViewData["Hello"] = "Hello GM";
            ViewData["RollNO"] = list;

            TempData["Name"] = "My Name is Sagar";
            TempData.Peek("Name");
            Session["petname"] = "110";
            return View();

        }
        public ActionResult Index1()
        {
            if (TempData.ContainsKey("Name"))
            {
                string Data = TempData.Peek("Name").ToString();
            }
            string petname= Session["petname"].ToString();
            TempData.Keep();
            return View();
        }

        public ActionResult Index2()
        {
            string Data = TempData.Peek("Name").ToString();
            TempData.Keep();
            return View();
        }



    }
}