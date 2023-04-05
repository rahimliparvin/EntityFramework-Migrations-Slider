using Microsoft.AspNetCore.Mvc;

namespace SophiaFronttoBack.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
