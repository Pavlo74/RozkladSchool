using Microsoft.AspNetCore.Mvc;
using Rozklad.Repository.Repositories;
using RozkladSchool.Models;
using System.Diagnostics;

namespace RozkladSchool.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ILogger<TeacherController> _logger;
        private readonly TeacherRepository _teacherRepository;
        public TeacherController(ILogger<TeacherController> logger, TeacherRepository teacherRepository)
        {
            _logger = logger;
            _teacherRepository = teacherRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _teacherRepository.GetTeacherAsync());
        }


        public IActionResult Privacy()
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
