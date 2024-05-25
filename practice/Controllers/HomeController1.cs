using Microsoft.AspNetCore.Mvc;

namespace practice.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
