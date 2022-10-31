using Microsoft.AspNetCore.Mvc;
using Rozklad.Repository.Repositories;
using RozkladSchool.Models;
using System.Diagnostics;

namespace RozkladSchool.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TimetableRepository _timetableRepository;
        public HomeController(ILogger<HomeController> logger, TimetableRepository timetableRepository)
        {
            _logger = logger;
            _timetableRepository = timetableRepository;
        }

        public IActionResult Index()
         {
            return View(_timetableRepository.GetTimetables());
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