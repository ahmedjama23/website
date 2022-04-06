using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnet.Models;

namespace dotnet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutMe()
        {
            using (var db = new DatabaseContext())
            {
                ViewData["Persona"] = db.Persona.First();
                ViewData["TechnicalSkills"] = db.TechnicalSkill.ToList();
                ViewData["SoftSkills"] = db.SoftSkill.ToList();
                ViewData["Educations"] = db.Education.ToList();
                ViewData["Jobs"] = db.Job.ToList();
                ViewData["Responsibilities"] = db.Responsibility.ToList();
            }

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
