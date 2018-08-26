using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using AspNetCore21Mvc.Models;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;

namespace AspNetCore21Mvc.Controllers
{
    public class HomeController : Controller
    {
        public ILogger<HomeController> Log { get; }
        public IOptionsSnapshot<AppSettings> Settings { get; }

        public HomeController(ILogger<HomeController> log, IOptionsSnapshot<AppSettings> settings)
        {
            Log = log;
            Settings = settings;
        }

        public IActionResult Index()
        {
            HttpContext.Session.SetString("Key", "Hello");

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = this.Settings.Value.SMTP_IP;

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            Log.LogCritical("聯絡頁面死掉了！");

            throw new Exception("BAD");

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
