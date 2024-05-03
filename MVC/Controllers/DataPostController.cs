using MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Reflection;

namespace MVC.Controllers
{
   
    public class DataPostController : Controller
    {
        SqlConnection con = new SqlConnection();
        // GET: DataPost
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(StudentModel model)
        {
            int result= AddDetails(model);
            return View(model);
        }
        
        public ActionResult Paramatarize()
        {
            List<string> Hobbies = new List<string>();
            Hobbies.Add("Cricket");
            Hobbies.Add("Football");
            Hobbies.Add("Khokho");
           ViewBag.Hobbs = Hobbies;
                
            return View();
        }
        [HttpPost]
        public ActionResult Post(string Name,string LastName,string FirstName,string Email,string Description,string Hobbie)
        {
            // Save Logic into DB

            List<string> Hobbies = new List<string>();
            Hobbies.Add("Cricket");
            Hobbies.Add("Football");
            Hobbies.Add("Khokho");
            ViewBag.Hobbs = Hobbies;
            StudentModel model = new StudentModel()
            {
                Name = Name,
                LastName= LastName,
                FirstName= FirstName,
                Email= Email,
                 Description= Description,
                 Hobbie = Hobbie
            };
            int result = AddDetails(model);
            return View("Paramatarize");
        }

        public ActionResult FormPost()
        {
            List<string> Hobbies = new List<string>();
            Hobbies.Add("Cricket");
            Hobbies.Add("Football");
            Hobbies.Add("Khokho");
            ViewBag.Hobbs = Hobbies;
            return View();
        }
        [HttpPost]
        public ActionResult FormPost(FormCollection form)
        {
            // Save Logic into DB
            StudentModel model = new StudentModel()
            {
                Name = form["Name"],
            LastName = form["LastName"],
            FirstName = form["FirstName"],
                Email = form["Email"],
                Description = form["Description"],
                Hobbie = form["Hobbie"]
            };
            int result = AddDetails(model);
            if (result > 0)
            {
                ViewBag.Message = "Save";
            }
            else
            {
                ViewBag.Message = "Fail";
            }
            List<string> Hobbies = new List<string>();
            Hobbies.Add("Cricket");
            Hobbies.Add("Football");
            Hobbies.Add("Khokho");
            ViewBag.Hobbs = Hobbies;
            return View();
        }
        public ActionResult JqueryPost_Param()
        {
            List<string> Hobbies = new List<string>();
            Hobbies.Add("Cricket");
            Hobbies.Add("Football");
            Hobbies.Add("Khokho");
            ViewBag.Hobbies = Hobbies;
            return View();
        }
        [HttpPost]
        public ActionResult JqueryPost_Param(string Name, string LastName, string FirstName, string Email, string Description, string Hobbie)
        {
            string result = "";
            try
            {
                List<string> Hobbies = new List<string>();
                Hobbies.Add("Cricket");
                Hobbies.Add("Football");
                Hobbies.Add("Khokho");
                ViewBag.Hobbies = Hobbies;
                StudentModel model = new StudentModel()
                {
                    Name = Name,
                    LastName = LastName,
                    FirstName = FirstName,
                    Email = Email,
                    Description = Description,
                    Hobbie = Hobbie
                };
                result = AddDetails(model).ToString();
            }
            catch (Exception ex)
            {
                result=ex.Message;
            }
            return Json(result.ToString(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult JqueryPost_model()
        {
            List<string> Hobbies = new List<string>();
            Hobbies.Add("Cricket");
            Hobbies.Add("Football");
            Hobbies.Add("Khokho");
            ViewBag.Hobbies = Hobbies;
            return View();
        }
        [HttpPost]
        public ActionResult JqueryPost_modellist(StudentModel model) // model
        {
            List<string> Hobbies = new List<string>();
            Hobbies.Add("Cricket");
            Hobbies.Add("Football");
            Hobbies.Add("Khokho");
            ViewBag.Hobbies = Hobbies;
            return Json("1", JsonRequestBehavior.AllowGet);
        }
        public ActionResult JqueryPost_modellist() // list
        {

            List<ProductModel> ProductModels = new List<ProductModel>()
            {
                new ProductModel { ProductID =1, Name ="ProductModel 1", Category = "Category 1", Description ="Description 1", Price = 10m, FileName="Invoice (1).pdf" },
                new ProductModel { ProductID =2, Name ="ProductModel 2", Category = "Category 1", Description ="Description 2", Price = 20m, FileName="Invoice (2).pdf"},
                new ProductModel { ProductID =3, Name ="ProductModel 3", Category = "Category 1", Description ="Description 3", Price = 30m, FileName="Invoice (3).pdf"},
                new ProductModel { ProductID =4, Name ="ProductModel 4", Category = "Category 2", Description ="Description 4", Price = 40m, FileName="Invoice (4).pdf"},
                new ProductModel { ProductID =5, Name ="ProductModel 5", Category = "Category 2", Description ="Description 5", Price = 50m, FileName= "Invoice (5).pdf"},
                new ProductModel { ProductID =6, Name ="ProductModel 6", Category = "Category 2", Description ="Description 6", Price = 50m, FileName= "Invoice (1).pdf"}
            };

            return View(ProductModels);
        }
        [HttpPost]
        public ActionResult JqueryPostllist(List<ProductModel> model) // list
        {
            List<string> Hobbies = new List<string>();
            Hobbies.Add("Cricket");
            Hobbies.Add("Football");
            Hobbies.Add("Khokho");
            ViewBag.Hobbies = Hobbies;
            return Json("1", JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult JqueryPost_model(StudentModel model)  // Model with List
        {
            List<string> Hobbies = new List<string>();
            Hobbies.Add("Cricket");
            Hobbies.Add("Football");
            Hobbies.Add("Khokho");
            ViewBag.Hobbies = Hobbies;
            return Json("1", JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult JqueryPost_Childmodel(StudentModel model)  // Model with Child model
        {
            List<string> Hobbies = new List<string>();
            Hobbies.Add("Cricket");
            Hobbies.Add("Football");
            Hobbies.Add("Khokho");
            ViewBag.Hobbies = Hobbies;
            return Json("1", JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult JqueryPost_ChilListdmodel(StudentModel model)  // Model with Child model & List
        {
            List<string> Hobbies = new List<string>();
            Hobbies.Add("Cricket");
            Hobbies.Add("Football");
            Hobbies.Add("Khokho");
            ViewBag.Hobbies = Hobbies;
            return Json("1", JsonRequestBehavior.AllowGet);
        }

        public ActionResult JqueryFormSubmit()
        {
            List<string> Hobbies = new List<string>();
            Hobbies.Add("Cricket");
            Hobbies.Add("Football");
            Hobbies.Add("Khokho");
            ViewBag.Hobbs = Hobbies;

            return View();
        }

        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            con = new SqlConnection(constr);

        }
        private int AddDetails(StudentModel model)
        {
            int id = 0;
            try
            {
                connection();
                SqlCommand com = new SqlCommand("Add_Sp_Name", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Name", model.Name);
                com.Parameters.AddWithValue("@LastName", model.LastName);
                com.Parameters.AddWithValue("@FirstName", model.FirstName);
                com.Parameters.AddWithValue("@Email", model.Email);
                com.Parameters.AddWithValue("@Description", model.Description);
                com.Parameters.AddWithValue("@Hobbie", model.Hobbie);
                con.Open();
                id = com.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                id = 0;
            }
            return id;
        }
    }
}