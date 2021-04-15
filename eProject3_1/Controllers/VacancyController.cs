using System;
using System.Collections.Generic;
using System.Linq;
using eProject3_1.Models;
using eProject3_1.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eProject3_1.Controllers
{
    [Authorize(Roles = "Employee")]
    public class VacancyController : Controller
    {
        private readonly IContextContextRepository _context;

        public VacancyController(IContextContextRepository repository)
        {
            _context = repository;
        }


        // GET
        public IActionResult Index()
        {
            string a=User.Identity.Name;
            ViewBag.Stat=_context.GetVacancyStatus().Where(s=>s.Id!=2).ToList();
            ViewBag.StatR = _context.GetVacancyStatus().ToList();
            return View(_context.GetVacancies());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.DepartmentId = _context.GetDepartments().Select(d => new SelectListItem
            {
                Text = d.Name,
                Value = d.Id
            });
            ViewBag.EmployeeId = _context.GetEmployees().Select(d => new SelectListItem
            {
                Text = d.Name,
                Value = d.Id.ToString()
            });
            ViewBag.StatusId = _context.GetStatusVacancy().Select(d => new SelectListItem
            {
                Text = d.Status,
                Value = d.Id.ToString()
            });
            return View(_context.GetVacancyForm());
        }

        [HttpPost]
        public IActionResult Create(Vacancy vac)
        {
            if (vac.Close != null && vac.CreateAt != null && !ModelState.IsValid &&
                DateTime.Compare((DateTime) vac.CreateAt, (DateTime) vac.Close) > 0)
                return View();
            return _context.CreateVacancy(vac) ? (IActionResult) RedirectToAction("Index") : View();
        }

        [HttpGet]
        public ViewResult Edit(string id)
        {
            ViewBag.DepartmentId = _context.GetDepartments().Select(d => new SelectListItem
            {
                Text = d.Name,
                Value = d.Id
            });
            ViewBag.EmployeeId = _context.GetEmployees().Select(d => new SelectListItem
            {
                Text = d.Name,
                Value = d.Id.ToString()
            });
            ViewBag.StatusId = _context.GetStatusVacancy().Select(d => new SelectListItem
            {
                Text = d.Status,
                Value = d.Id.ToString()
            });
            return View(_context.GetVacancy(id));
        }

        [HttpPost]
        public IActionResult Edit(Vacancy vac)
        {
            if (!ModelState.IsValid) return View();
            _context.EditVacancy(vac);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            ViewBag.Apps = _context.GetChosenApplicants(id);
            return View(_context.GetVacancy(id));
        }

        [HttpGet("Vacancy/ChangeStats/{id}/{stat}")]
        public IActionResult ChangeStats(string id, string stat)
        {
            if (_context.SetVacancyStatus(id, Convert.ToInt32(stat)) == false) return RedirectToAction("Index","Account");
            return RedirectToAction("Index");
        }
    }
}