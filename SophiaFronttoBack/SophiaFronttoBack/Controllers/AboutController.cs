using Microsoft.AspNetCore.Mvc;

namespace SophiaFronttoBack.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
