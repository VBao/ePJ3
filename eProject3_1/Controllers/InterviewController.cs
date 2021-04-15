using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
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
            ViewBag.Stat = _context.GetApplicantStatus();
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
        
        [HttpGet("Interview/ChangeStats/{id}/{stat}")]
        public IActionResult ChangeStats(string id, string stat)
        {
            if (_context.SetInterviewStatus(Convert.ToInt32(id), Convert.ToInt32(stat)) == false) return RedirectToAction("Index","Account");
            return RedirectToAction("Index");
        }
        
        //TODO Interview details
        [HttpGet]
        public IActionResult ChooseInterviewer(string id)
        {
            ViewBag.interviewId = id;
            return View(_context.GetInterviewers(interviewListId:id));
        }

        [HttpGet("Interview/InterviewSchedule/{interId}/{interviewerId}")]
        public IActionResult InterviewSchedule(int interId,int interviewerId,string? error)
        {
            ViewBag.Err = error ?? "";
            return View(_context.GetScheduleForm(interId,interviewerId));
        }

        [HttpPost]
        public IActionResult PostInterviewSchedule(InterviewDetail detail)
        {
            if (!_context.CheckTime(detail.StartTime, detail.EndTime, detail.Id))
            {
                
                return RedirectToAction("InterviewSchedule",new {error="Please input right start and end time"});
            }
            
            if (_context.CreateSchedule(detail) == false) return RedirectToAction("Index","Account");
            return RedirectToAction("Index");
        }
    }
}
