using Microsoft.AspNetCore.Mvc;

namespace TempData_KeepvsPeek.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            TempData["Message"] = "Welcome"; //storing value in tempdata


            if (TempData != null)
            {
                object value = TempData.Peek("Message");

                ViewBag.Data = value;
            }
            return View();
          
        }
        public IActionResult Index2()
        {
            if (TempData != null)
            {
                object value = TempData.Peek("Message");

                ViewBag.Data = value;
            }
            return View();
        }
        public IActionResult Index3()
        {
            if (TempData != null)
            {
                object value = TempData.Peek("Message");

                ViewBag.Data = value;
            }
            return View();
        }
    }
}
