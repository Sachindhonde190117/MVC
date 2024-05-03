using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ActionSelectorsController : Controller
    {
        // GET: ActionSelectors
        public ActionResult Index()
        {
            var Name = GetByID();
            return View();
        }

        [ActionName("User")]
        public ActionResult UserList()
        {
            var Name = GetByID();
            return View();
        }

        // Optional URI Parameter
        // URL: /MVCTest/
        // URL: /MVCTest/Pranaya
        [Route("MVCTest/{studentName:alpha}")]
        public string MVC(string studentName)
        {

            return "Welcome "+ studentName + " to ASP.NET MVC!";
        }
        // Optional URI Parameter with default value
        // URL: /WEBAPITest/
        // URL: /WEBAPITest/Pranaya
        [Route("WEBAPITest/studentName/{studentName}")]
        public string WEBAPI(string studentName)
        {
            return "Welcome  "+ studentName + " to ASP.NET WEB API!";
        }

        [Route("Employee/{Id}")]
        public string GetEmployeeById(int Id)
        {
            return $"Return Employee Details : {Id}";
        }
        [Route("Employee/Gender/{Gender}/City/{CityId}")]
        public string GetEmployeesByGenderAndCity(string Gender, int CityId)
        {
            return $"Return Employees with Gender : {Gender}, City: {CityId}";
        }

        [Route("MethodFruit")]
        public string Fruit()
        {
            return "Hi...............";
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            deleteID(id);
            return View();
        }

        public ActionResult Delete(ProductModel model)
        {
            //deleteID(model.ProductID);
            return View();
        }

        
        private int deleteID(int id)
        {
            
            return 0;
        }

        [NonAction]
        public List<int> GetByID()
        {
            List<int> id = new List<int>();
            id.Add(1);
            id.Add(2);
            return id;
        }
    }
}