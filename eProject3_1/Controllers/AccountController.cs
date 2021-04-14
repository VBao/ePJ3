using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using eProject3_1.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace eProject3_1.Controllers
{
    public class AccountController : Controller
    {
        private readonly HrContext _ctx;

        public AccountController(HrContext context)
        {
            _ctx = context;
        }

        [Authorize(Roles = "Admin, Employee, Interviewer, Applicant")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string userName, string password)
        {
            if (!string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(password))
            {
                return RedirectToAction("Login");
            }

            //Check the user name and password
            //Here can be implemented checking logic from the database
            ClaimsIdentity identity = null;
            bool isAuthenticated = false;
            if (_ctx.Employee.Where(u => string.Compare(u.Username, userName) == 0)
                .FirstOrDefault(u => string.Compare(password, u.Password) == 0) != null)
            {
                Employee e = _ctx.Employee.Where(u => u.Username == userName)
                    .FirstOrDefault(u => u.Password == password);
                if (e.IsAdmin == true)
                {
                    identity = new ClaimsIdentity(new[]
                    {
                        new Claim(ClaimTypes.Name, userName),
                        new Claim(ClaimTypes.Role, "Admin"),
                    }, CookieAuthenticationDefaults.AuthenticationScheme);
                }
                else
                {
                    identity = new ClaimsIdentity(new[]
                    {
                        new Claim(ClaimTypes.Name, userName),
                        new Claim("eId",e.Id.ToString()),
                        new Claim(ClaimTypes.Role, "Employee")
                    }, CookieAuthenticationDefaults.AuthenticationScheme);
                }

                isAuthenticated = true;
            }
            else if (_ctx.Interviewer.Where(u => u.Username == userName).FirstOrDefault(u => u.Password == password) ==
                     null)
            {
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, userName),
                    new Claim(ClaimTypes.Role, "Interviewer")
                }, CookieAuthenticationDefaults.AuthenticationScheme);

                isAuthenticated = true;
            }
            else if (_ctx.Applicant.Where(u => u.Username == userName).FirstOrDefault(u => u.Password == password) ==
                     null)
            {
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, userName),
                    new Claim(ClaimTypes.Role, "Applicant")
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                isAuthenticated = true;
            }

            if (isAuthenticated)
            {
                var principal = new ClaimsPrincipal(identity);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                return RedirectToAction("Index", "Account");
            }

            return View();
        }


        public IActionResult Logout()
        {
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
    }
}