using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class Returntype : Controller
    {
        public IActionResult ReturnText()
        {
            return View();
        }

        public IActionResult ReturnJson()
        {
            return Json(new
            {
                apptype = "MVC.Net",
                appname = "MVC",
                appdesc = "This is an example of returning JSON data"
            });

        }
        
        public IActionResult ReturnHtml()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
