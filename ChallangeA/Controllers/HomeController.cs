using ChallangeA.Interface;
using ChallangeA.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChallangeA.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IProductList _products)
        {
            this.products = _products;
        }
        private readonly IProductList products =null;

        public ActionResult Index()
        {
            this.products.Add(new Product { Name = "Atari", Description = "Game 1" });
            this.products.Add(new Product { Name = "Megadrive", Description = "Game 2" });
            this.products.Add(new Product { Name = "Nintendo", Description = "Game 3" });

            return View(this.products);
        }

        public JsonResult AddItems()
        {
            this.products.Add(new Product { Name = "Atari", Description = "Async Game 1" });
            this.products.Add(new Product { Name = "Megadrive", Description = "Async Game 2" });
            this.products.Add(new Product { Name = "Nintendo", Description = "Async Game 3" });

            return Json(this.products, JsonRequestBehavior.AllowGet);
        }
    }
}