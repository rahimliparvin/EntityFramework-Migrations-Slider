using Microsoft.AspNetCore.Mvc;
using SophiaFronttoBack.Data;
using SophiaFronttoBack.Models;
using System.Diagnostics;

namespace SophiaFronttoBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();

            return View(sliders);
        }
    }
}