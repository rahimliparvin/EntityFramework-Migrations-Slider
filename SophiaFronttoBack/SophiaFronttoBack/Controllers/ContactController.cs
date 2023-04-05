using Microsoft.AspNetCore.Mvc;

namespace SophiaFronttoBack.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
