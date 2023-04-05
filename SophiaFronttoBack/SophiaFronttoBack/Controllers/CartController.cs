using Microsoft.AspNetCore.Mvc;

namespace SophiaFronttoBack.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
