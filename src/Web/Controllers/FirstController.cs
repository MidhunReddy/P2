using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class FirstController : Controller
    {
       
        public IActionResult Addition()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Greeting()
        {
            return Content("Hello!");
        }

        public IActionResult JSON()
        {
            return Json(new
            {
                apptype = ".NET Core",
                appname = "MVC"
            });
        }
        public IActionResult HTML()
        {
            return Content("<!DOCTYPE html><html><body>Hello World</body></html>", "text/html");
        }



    }
}
