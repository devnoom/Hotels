using Hotels.Domain.entities;
using Hotels.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

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
            if (obj.Name == obj.Description)
            {
                ModelState.AddModelError("name", "The description cannot match the name");
            }
            if (ModelState.IsValid)
            {
                _context.Namastes.Add(obj);
                _context.SaveChanges();

                TempData["Success"] = "The Hotel has been created successfully";
                return RedirectToAction("Index", "Namaste");
            }

            TempData["Error"] = "The hotel could not be Updated";
            return View(obj);
        }
        public IActionResult Update(int NamasteId)
        {
            Namaste? obj = _context.Namastes.FirstOrDefault(u => u.Id == NamasteId);
            //Namaste? ob = _context.Namastes.Find(NamasteId);
            //var HotolList = _context.Namastes.Where(u => u.Price > 50 && u.Occupancy > 0);
            if (obj == null)
            {
                return RedirectToAction("Error", "Home");
            };


            return View(obj);
        }

        [HttpPost]
        public IActionResult Update(Namaste obj)
        {

            if (ModelState.IsValid)
            {
                _context.Namastes.Update(obj);
                _context.SaveChanges();
                TempData["Success"] = "The Hotel has been updated successfully";
                return RedirectToAction("Index", "Namaste");
            }
            TempData["Error"] = "The hotel could not be Updated";
            return View(obj);
        }
        public IActionResult Delete(int NamasteId)
        {
            Namaste? obj = _context.Namastes.FirstOrDefault(u => u.Id == NamasteId);

            if (obj == null)
            {
                return RedirectToAction("Error", "Home");
            };


            return View(obj);
        }

        [HttpPost]
        public IActionResult Delete(Namaste obj)
        {
            Namaste? objFromDb = _context.Namastes.FirstOrDefault(u => u.Id == obj.Id);

            if (objFromDb is not null)
            {
                _context.Namastes.Remove(objFromDb);
                _context.SaveChanges();
                TempData["Success"] = "The Hotel has been deleted successfully";
                return RedirectToAction("Index");
            }

            TempData["Error"] = "The hotel could not be deleted";
            return View();
        }



    }
}
