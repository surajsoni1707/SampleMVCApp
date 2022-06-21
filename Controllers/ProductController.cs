using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleMVCApp.Models;

namespace SampleMVCApp.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult GetAllProduct()
        {
            List<Product> productList1 = new List<Product>()
            {
                new Product{Id=1,Name="Abc",Company="Comp1",Price=10.1 },
                new Product{Id=2,Name="Pqr",Company="Comp2",Price=100.1 },
                new Product{Id=3,Name="Xyz",Company="Comp3",Price=130.1 },
                new Product{Id=4,Name="MC",Company="Comp4",Price=140.1 }
            };
            ViewBag.ProductList = productList1;
            return View();
        }
    }
}