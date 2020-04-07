using Microsoft.AspNetCore.Mvc;

namespace EquipmentManager.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Minor()
        {

            return View();
        }

    }
}
