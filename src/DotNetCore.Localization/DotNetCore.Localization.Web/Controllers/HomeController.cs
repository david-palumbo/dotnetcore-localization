using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore.Localization.Web.Resources.Default;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.Localization.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = ResourceRegistry.Instance.Get("en-US").HomeController.AboutMessage;
            //ViewData["Message"] = CultureInfo.CurrentUICulture.Name;


            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}