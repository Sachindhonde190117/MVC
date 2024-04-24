using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class ProductController : Controller
    {
        static List<ProductModel> ProductModels;
        // GET: ProductModel
        public ActionResult Index()
        {
            return View(Getall());
        }

        public PartialViewResult AdminList() // Action method
        {
            return PartialView("_ProductList", Getall());
        }
        public PartialViewResult CustList() // Action method
        {
            List<ProductModel> ProductModels = new List<ProductModel>()
            {
                new ProductModel { ProductID =1, Name ="ProductModel 1", Category = "Category 1", Description ="Description 1", Price = 10m}
            };
            return PartialView("_ProductList", ProductModels);
        }
        public ActionResult ProductList()
        {
            return View();
        }

        [NonAction]
        public List<ProductModel> Getall()  //non action method Private
        {
            ProductModels = new List<ProductModel>()
            {
                new ProductModel { ProductID =1, Name ="ProductModel 1", Category = "Category 1", Description ="Description 1", Price = 10m, FileName="Invoice (1).pdf" },
                new ProductModel { ProductID =2, Name ="ProductModel 2", Category = "Category 1", Description ="Description 2", Price = 20m, FileName="Invoice (2).pdf"},
                new ProductModel { ProductID =3, Name ="ProductModel 3", Category = "Category 1", Description ="Description 3", Price = 30m, FileName="Invoice (3).pdf"},
                new ProductModel { ProductID =4, Name ="ProductModel 4", Category = "Category 2", Description ="Description 4", Price = 40m, FileName="Invoice (4).pdf"},
                new ProductModel { ProductID =5, Name ="ProductModel 5", Category = "Category 2", Description ="Description 5", Price = 50m, FileName= "Invoice (5).pdf"},
                new ProductModel { ProductID =6, Name ="ProductModel 6", Category = "Category 2", Description ="Description 6", Price = 50m, FileName= "Invoice (1).pdf"}
            };
            return ProductModels;
        }
        [HttpPost]
        public ActionResult Details(int productId)
        {
            var model = Getall().Find(x=> x.ProductID == productId);
            return PartialView("_ProductDetails", model);
        }

        [HttpPost]
        public JsonResult DetailsByID(int productId)
        {
            var model = Getall().Find(x => x.ProductID == productId);
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public FileResult Download(string fileName)
        {
            //Build the File Path.
            string path = Server.MapPath("~/Invoice/") + fileName;

            //Read the File data into Byte Array.
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            //Send the File to Download.
            return File(bytes, "application/octet-stream", fileName);
        }

        
    }
}