using System;
using System.Linq;
using eProject3_1.Models;
using eProject3_1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eProject3_1.Controllers
{
    public class ApplicantController : Controller
    {
        private readonly IContextContextRepository _context;

        public ApplicantController(IContextContextRepository repository)
        {
            _context = repository;
        }


        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Stat = _context.GetApplicantStatus();
            return View(_context.GetApplicants());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.StatusId = _context.GetApplicantStatus().Select(l => new SelectListItem
            {
                Text = l.Status,
                Value = l.Id.ToString()
            });
            Applicant a = _context.GetApplicantForm();
            return View(a);
        }

        [HttpPost]
        public IActionResult Create(Applicant app)
        {
            return _context.CreateApplicant(app) ? (IActionResult) RedirectToAction("Index") : View();
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            // return View(_context.GetVacancy(id));
            return View(_context.GetApplicant(id));
        }

        [HttpGet]
        public ViewResult Edit(string id)
        {
            return View(_context.GetApplicant(id));
        }

        [HttpPost]
        public IActionResult Edit(Applicant app)
        {
            if (!ModelState.IsValid) return View();
            _context.EditApplicant(app);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult ChangeStats(string id, string stat)
        {
            if (_context.SetApplicantStatus(id, Convert.ToInt32(stat)) == false) return RedirectToAction("Index","Account");
            return RedirectToAction("Index");
        }
    }
}