using Microsoft.AspNetCore.Mvc;

namespace ShagoWeb.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Drive()
        {
            return View();
        }
    }
}
