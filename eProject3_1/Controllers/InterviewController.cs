using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProject3_1.Models;
using eProject3_1.Services;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eProject3_1.Controllers
{
    public class InterviewController : Controller
    {
        private readonly IContextContextRepository _context;
        public InterviewController(IContextContextRepository context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
            return View(_context.GetListInterview());
        }

        [HttpGet]
        public IActionResult CreateInterview()
        {
            ViewBag.VacancyId = _context.GetVacancies().Select(v=>new SelectListItem
            {
                Value = v.Id,
                Text = v.Id
            });
            ViewBag.ApplicantId=_context.GetApplicants().Select(v=>new SelectListItem
            {
                Value = v.Id,
                Text = v.Id
            });
            ViewBag.StatusId = _context.GetInterviewStatus().Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = s.Status
            });
            
            ViewBag.Apps = _context.GetApplicants();
            ViewBag.Vacs = _context.GetVacancies();
            return View(new ApplicantionList());
        }

        [HttpPost]
        public IActionResult CreateInterview(ApplicantionList al)
        {
            if (_context.CreateListInterview(al) == false) return RedirectToAction("Index","Account");
            return RedirectToAction("Index");
        }
    }
}
