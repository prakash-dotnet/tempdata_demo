using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using TempData_KeepvsPeek.Models;

namespace TempData_KeepvsPeek.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //TempData.Keep() Demo
        public IActionResult Index()
        {
            TempData["Message"] = "Hello"; //storing value in tempdata
            //TempData.Keep("Message"); //available to Index2
            return View();
        }
        public IActionResult Index2()
        {
            //TempData.Keep("Message");//available to Index3
            return View();
        }

        public IActionResult Index3()
        {
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