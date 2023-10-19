using Hotels.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.Web.Controllers
{
   
    public class NamasteController : Controller
    {
        private readonly ApplicationDbContext _context;
        public NamasteController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var hotels = _context.Namastes.ToList(); 
            return View(hotels);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
