using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using System;
using System.Collections.Generic;

namespace PassingData.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            string userName = "Enes";
            return View(userName as Object);
        }

        public IActionResult ProductShow()
        {

            Product product = new Product();
            product.ProductName = "Television";
            product.UnitPrice = 5;
            return View(product);
        }

        public IActionResult GetProductList()
        {
            List<Product> products = new List<Product>()
            {
                new Product() {ProductName = "Laptop", CategoryName = "Electronic", UnitPrice = 7},
                new Product() {ProductName = "Phone", CategoryName = "Electronic", UnitPrice = 5},
                new Product() {ProductName = "Fridge", CategoryName = "White Goods", UnitPrice = 7},
                new Product() {ProductName = "Armchair", CategoryName = "Houshold Goods", UnitPrice = 7}
            };
            return View(products);
        }
    }
}
