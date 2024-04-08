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
            List<ProductModel> ProductModels = new List<ProductModel>()
            {
                new ProductModel { ProductID =1, Name ="ProductModel 1", Category = "Category 1", Description ="Description 1", Price = 10m},
                new ProductModel { ProductID =2, Name ="ProductModel 2", Category = "Category 1", Description ="Description 2", Price = 20m},
                new ProductModel { ProductID =3, Name ="ProductModel 3", Category = "Category 1", Description ="Description 3", Price = 30m},
                new ProductModel { ProductID =4, Name ="ProductModel 4", Category = "Category 2", Description ="Description 4", Price = 40m},
                new ProductModel { ProductID =5, Name ="ProductModel 5", Category = "Category 2", Description ="Description 5", Price = 50m},
                new ProductModel { ProductID =6, Name ="ProductModel 6", Category = "Category 2", Description ="Description 6", Price = 50m}
            };
            return ProductModels;
        }
        [HttpPost]
        public PartialViewResult Details(int productId)
        {
            var model = Getall().Find(x=> x.ProductID == productId);
            return PartialView("_ProductDetails", model);
        }
    }
}