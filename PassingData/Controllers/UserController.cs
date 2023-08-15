using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using System.Collections.Generic;

namespace PassingData.Controllers
{
    public class UserController : Controller
    {
        List<User> users = new List<User>()
        {
            new User() {FirstName = "Yusuf", LastName = "Ozdogan"},
            new User() {FirstName = "Burak", LastName = "Uyanik"},
            new User() {FirstName = "Emrah", LastName = "Kacar"}
        };

        public IActionResult UseViewBag()
        {
            ViewBag.UserName = "Enes";

            User user = new User();
            user.FirstName = "Furkan";
            user.LastName = "Orhan";
            ViewBag.User = user;

            ViewBag.Users = users;
            return View();
        }

        public IActionResult UseViewData()
        {
            ViewData["UserName"] = "Enes";

            User user = new User();
            user.FirstName = "Orhan";
            user.FirstName = "Serhan";

            ViewData["User"] = user;

            ViewData["Users"] = users;
            return View();
        }

        public IActionResult UseTempData()
        {
            TempData["name"] = "Murat";
            return RedirectToAction("TempDataTest");
        }

        public IActionResult TempDataTest()
        {
            TempData.Keep("name");
            //string name = TempData["name"].ToString();
            return View();
        }
    }
}
