using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Class = "Software";
            ViewBag.ServicesDropDown = true;
            return View();
        }
        public IActionResult DataAnatytics()
        {
            ViewBag.Class = "Data";
            ViewBag.ServicesDropDown = true;
            return View();
        }
        public IActionResult Devops()
        {
            ViewBag.Class = "DevOps";
            ViewBag.ServicesDropDown = true;
            return View();
        }
        public IActionResult SoftwareTesting()
        {
            ViewBag.Class = "Testing";
            ViewBag.ServicesDropDown = true;
            return View();
        }
        public IActionResult HybridMobileApp()
        {
            ViewBag.Class = "Hybrid";
            ViewBag.ServicesDropDown = true;
            return View();
        }

        public IActionResult GraphicDesign()
        {
            ViewBag.Class = "Graphic";
            ViewBag.ServicesDropDown = true;
            return View();
        }
      
        public IActionResult Ecommerce()
        {
            ViewBag.Class = "Ecommerce";
            ViewBag.ServicesDropDown = true;

            return View();
        }
        public IActionResult DigitalMarketing()
        {
            ViewBag.Class = "Digital";
            ViewBag.ServicesDropDown = true;
            return View();
        }

        public IActionResult SocialMediaMarketing()
        {
            ViewBag.Class = "Social";
            ViewBag.ServicesDropDown = true;
            return View();
        }

        public IActionResult SearchEngineOpt()
        {
            ViewBag.Class = "Search";
            ViewBag.ServicesDropDown = true;
            return View();
        }

    }
}