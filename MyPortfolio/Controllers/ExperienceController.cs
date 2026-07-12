using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly AppDbContext _context;

        public ExperienceController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult ExperienceList()
        {
            var experiences = _context.Experiences.ToList();
            return View(experiences);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            if (!ModelState.IsValid)
            {
                return View(experience);
            }            
            if(experience.EndDate == null && !experience.IsActive) {
                ModelState.AddModelError("EndDate", "Lütfen bitiş tarihini giriniz veya 'Hala çalışıyorum' kutucuğunu işaretleyiniz.");
                return View(experience);
            }
            if (experience.IsActive)
            {
                experience.EndDate = "Halen Devam Ediyor";
            }
            _context.Experiences.Add(experience);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
