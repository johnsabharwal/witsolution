using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Class = "About";
            ViewBag.AboutDropDown = true;
            return View();
        }

        public IActionResult Vision()
        {
            ViewBag.Class = "Vision";
            ViewBag.AboutDropDown = true;
            return View();
        }
    }
}
