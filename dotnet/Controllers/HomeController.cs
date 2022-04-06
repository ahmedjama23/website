using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnet.Models;
using dotnet.Models.TechnicalSkills;
using dotnet.Models.SoftSkills;
using dotnet.Models.Personas;
using dotnet.Models.Educations;
using dotnet.Models.Jobs;

namespace dotnet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ITechnicalSkillRepository _technicalSkillRepository = new MockTechnicalSkillRepository();
        private ISoftSkillRepository _softSkillRepository = new MockSoftSkillRepository();
        private IEducationRepository _educationRepository = new MockEducationRepository();
        private IJobRepository _jobRepository = new MockJobRepository();
        private Persona persona = new Persona();

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
            ViewData["Persona"] = persona;
            ViewData["TechnicalSkillRepository"] = _technicalSkillRepository;
            ViewData["SoftSkillRepository"] = _softSkillRepository;
            ViewData["EducationRepository"] = _educationRepository;
            ViewData["JobRepository"] = _jobRepository;
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
