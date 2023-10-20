using Hotels.Domain.entities;
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
        [HttpPost]
        public IActionResult Create(Namaste obj)
        {
            if(obj.Name == obj.Description)
            {
                ModelState.AddModelError("name","The description cannot match the name");
            }
            if (ModelState.IsValid)
            {
                _context.Namastes.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Index", "Namaste");
            }
            return View(obj);
        }
        public IActionResult Update(int NamasteId)
        {
            Namaste? obj = _context.Namastes.FirstOrDefault(u=>u.Id == NamasteId);
            if(obj == null)
            {
                return NotFound();
            };
            return View(obj);
        }

    }
}
