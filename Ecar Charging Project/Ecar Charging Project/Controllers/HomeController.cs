using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ecar_Charging_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Tips()
        {
            ViewData["Message"] = "Energy Saving Tips.";

            return View();
        }


        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult test()
        //test link, copy this  and rename to the same name as the page, see Views/Home/test.cshtml for a example
        // to add a link go to _layout.cshtml and add a link in the <ul class="nav navbar-nav"> section 
        {
            ViewData["Message"] = "Your test page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
