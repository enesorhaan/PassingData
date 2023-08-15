using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using PassingData.Models.ViewModel;
using System;
using System.Collections.Generic;

namespace PassingData.Controllers
{
    public class CustomerController : Controller
    {
        List<Customer> customers = new List<Customer>()
        {
            new Customer() {FirstName = "Enes", LastName = "Orhan"},
            new Customer() {FirstName = "Çiğdem", LastName = "Öztutan"},
            new Customer() {FirstName = "Veysel", LastName = "Aydın"},
        };
        public IActionResult UseViewModel()
        {
            Product product = new Product();
            product.ProductName = "Monitor";
            product.CategoryName = "Electronic";
            product.UnitPrice = 1;

            string date = DateTime.Now.ToString();

            CustomerAndProductVM customerAndProduct = new CustomerAndProductVM();
            customerAndProduct.customers = customers;
            customerAndProduct.product = product;
            customerAndProduct.date = date;

            return View(customerAndProduct);
        }

        public IActionResult UseTuple()
        {
            Product product = new Product();
            product.ProductName = "Phone";
            product.CategoryName = "Electronic";
            product.UnitPrice = 4;

            string date = DateTime.Now.ToString();

            (List<Customer>, Product, string) customerAndProduct = (customers,product,date);

            return View(customerAndProduct);
        }
    }
}
