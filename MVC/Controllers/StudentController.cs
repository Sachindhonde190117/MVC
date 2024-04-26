using MVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        { 
            //1. Model  
            DataTable dt= new DataTable(); // SP

            StudentModel model = new StudentModel()
            {
                Name="Suresh More",
                Description="Hello Suresh",
                Email="Suresh@gamil.com",
                FirstName="Suresh",
                Id=1,
                LastName="more",
                Hobbies= new List<string>()
                {
                    "Cricket",
                    "Football",
                    "Khokho"
                }
            };
         
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(StudentModel model) 
        {
        
            return View(model);
        }

        public ActionResult Myview()
        {
            return RedirectToRoute("HelloSagar");

        }
        public ActionResult Myview1()
        {
            return Content("Hi............");
        }
        public ActionResult Post()
        {
            return Redirect("Index");
        }
    }
}