using Microsoft.AspNetCore.Mvc;

namespace CarritoRazor.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Usuarios()
        {
            return View();
        }

    }
}