using Microsoft.AspNetCore.Mvc;
using Rozklad.Repository.Repositories;
using RozkladSchool.Models;
using System.Diagnostics;

namespace RozkladSchool.Controllers
{
    public class TimetableController : Controller
    {
       
        private readonly ILogger<TimetableController> _logger;
        private readonly TimetableRepository _timetableRepository;
        public TimetableController(ILogger<TimetableController> logger, TimetableRepository timetableRepository)
        {
            _logger = logger;
            _timetableRepository = timetableRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _timetableRepository.GetTimetableAsync());
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
