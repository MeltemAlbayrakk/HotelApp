using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Otelim.Context;

namespace Otelim.Controllers
{
    public class ThemeController : Controller
    {

        private readonly HotelContext _context;
        public ThemeController(HotelContext context)
        {
            _context = context;
        }

        
        public IActionResult Index()
        {
            return View();
        }
    }
}
