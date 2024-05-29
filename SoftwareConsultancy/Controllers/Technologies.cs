using Microsoft.AspNetCore.Mvc;

namespace WitSolutions.Controllers
{
    public class Technologies : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Class = "Net";
            ViewBag.TechnologyDropDown = true;
            return View();
        }
       

        public IActionResult Cloud()
        {
            ViewBag.Class = "Cloud";
            ViewBag.TechnologyDropDown = true;
            return View();
        }

        public IActionResult Php()
        {
            ViewBag.Class = "Php";
            ViewBag.TechnologyDropDown = true;
            return View();
        }

    }
}
