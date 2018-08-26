using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using AspNetCore21Mvc.Models;

namespace AspNetCore21Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IAppSettings A1 { get; }
        public IAppSettingsScoped A2 { get; }
        public IAppSettingsSingleton A3 { get; }

        public HomeController(IAppSettings a1, IAppSettingsScoped a2, IAppSettingsSingleton a3)
        {
            A1 = a1;
            A2 = a2;
            A3 = a3;
        }


        public IActionResult Test1()
        {
            return Content(A1.Name);
        }
        public IActionResult Test2()
        {
            return Content(A2.Name);
        }
        public IActionResult Test3()
        {
            return Content(A3.Name);
        }


        public IActionResult Index()
        {
            HttpContext.Session.SetString("Key", "Hello");

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = HttpContext.Session.GetString("Key");

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
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
