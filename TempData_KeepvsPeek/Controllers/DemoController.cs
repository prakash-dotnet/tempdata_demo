using Microsoft.AspNetCore.Mvc;

namespace TempData_KeepvsPeek.Controllers
{
    public class DemoController : Controller
    {
        //Keep() Demo2
        public IActionResult Index()
        {
            TempData["Message"] = "Welcome"; //storing value in tempdata
            object value = TempData["Message"];

            if (TempData != null)
            {
                TempData.Keep("Message");
            }
            ViewBag.Data = value;
            return View();
        }
        public IActionResult Index2()
        {
            ViewBag.Data = TempData["Message"];
            if (TempData != null)
            {
                TempData.Keep("Message");
            }
            return View();
        }
        public IActionResult Index3()
        {
            ViewBag.Data = TempData["Message"];
            return View();
        }
    }
}
