using Microsoft.AspNetCore.Mvc;

namespace SophiaFronttoBack.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
