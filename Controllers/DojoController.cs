using System;
using System.Linq;
using System.Diagnostics;
using DojoActivities.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DojoActivities.Controllers
{
    public class DojoController : Controller
    {
        private DojoActivityContext context;
        public static PasswordHasher<User> RegisterHasher = new PasswordHasher<User>();
        public static PasswordHasher<UserLogin> LoginHasher = new PasswordHasher<UserLogin>();

        public DojoController (DojoActivityContext dbContext)
        {
            context = dbContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User u)
        {
            User userInDb = context.GetUserByEmail(u.Email);

            if(userInDb != null) 
            {
                ModelState.AddModelError("Email", "Email already exist!");
            }
            
            if(ModelState.IsValid)
            {
                u.Password = RegisterHasher.HashPassword(u, u.Password);
                HttpContext.Session.SetInt32("UserId", context.Create(u));
                return Redirect("/dojocenter");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost("login")]
        public IActionResult Login(UserLogin userSubmitted)
        {
            User userInDb = context.GetUserByEmail(userSubmitted.LoginEmail);
            
            if(userInDb == null) 
            {
                ModelState.AddModelError("LoginEmail", "Please enter a correct Email!");
            }
            
            if(ModelState.IsValid)
            {
                var result = LoginHasher.VerifyHashedPassword(userSubmitted, userInDb.Password, userSubmitted.LoginPassword);

                if (result == 0)
                {
                    ModelState.AddModelError("LoginPassword", "Please enter a correct Password!");
                }
                else
                {
                    HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                    return Redirect("/dojocenter");
                }
            }
            
            return View("Index");
        }

        [HttpGet("dojocenter")]
        public IActionResult DojoCenter(DojoActivity a)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");

            if (UserId == null)
            {
                return Redirect("/");
            }

            else
            {
                ViewBag.User = context.GetUserById((int)UserId);

                ViewBag.Activities = context.Activities
                    .Include(act1 => act1.Coordinator)
                    .Include(act => act.UserParticipating)
                    .OrderByDescending(d => d.Date)
                    .ToList();

                return View();
            }

        }

        [HttpGet("activity/new")]
        public IActionResult Activity()
        {
            return View();
        }

        [HttpPost("activity/create")]
        public IActionResult CreateActivity(DojoActivity d)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");

            if(ModelState.IsValid)
            {
                d.CoordinatorId = (int)UserId;
                context.Create(d);
                return Redirect("/dojocenter");
            }
            
            return View("Activity");
        }

        [HttpGet("activityInfo/{activityId}")]
        public IActionResult ActivityInfo(int activityId)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            ViewBag.Users = (int)UserId;
            ViewBag.User = context.GetUserById(activityId);

            ViewBag.Activities = context.Activities
                .Include(a => a.UserParticipating)
                .ThenInclude(p => p.Ninja)
                .Include(b => b.Coordinator)
                .FirstOrDefault(d => d.ActivityId == activityId);

            return View();
        }

        [HttpGet("join/{ActivityId}")]
        public IActionResult Join(int ActivityId)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            Participant p = new Participant();
            p.ActivityId = ActivityId;
            p.UserId = (int)UserId;
            context.Create(p);
            return Redirect("/dojocenter");
        }

        [Route("leave/{ActivityId}")]
        [HttpGet]
        public IActionResult UnRSVP(int ActivityId)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            context.Remove(ActivityId, (int)UserId);
            return Redirect("/dojocenter");
        }

        [Route("delete/{ActivityId}")]
        [HttpGet]
        public IActionResult Delete(int ActivityId)
        {
            context.Remove(ActivityId);
            return Redirect("/dojocenter");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/");
        }

    }
}
