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
            if (experience.EndDate == null && !experience.IsActive)
            {
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

        public IActionResult DeleteExperience(int id)
        {
            var experience = _context.Experiences.Find(id);
            if (experience == null)
            {
                return NotFound();
            }
            _context.Experiences.Remove(experience);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var experience = _context.Experiences.Find(id);
            if (experience != null)
            {
                if (DateTime.TryParse(experience.StartDate, out DateTime startDate))
                {
                    experience.StartDate = startDate.ToString("yyyy-MM-dd");
                }

                if (!experience.IsActive && DateTime.TryParse(experience.EndDate, out DateTime endDate))
                {
                    experience.EndDate = endDate.ToString("yyyy-MM-dd");
                }
                else if (experience.IsActive)
                {
                    experience.EndDate = "";
                }
            }
            return View(experience);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            if (!ModelState.IsValid)
            {
                return View(experience);
            }
            if (experience.EndDate == null && !experience.IsActive)
            {
                ModelState.AddModelError("EndDate", "Lütfen bitiş tarihini giriniz veya 'Hala çalışıyorum' kutucuğunu işaretleyiniz.");
                return View(experience);
            }
            if (experience.IsActive)
            {
                experience.EndDate = "Halen Devam Ediyor";
            }
            _context.Experiences.Update(experience);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

    }
}
