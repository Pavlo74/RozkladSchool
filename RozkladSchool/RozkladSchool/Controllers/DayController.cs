using Microsoft.AspNetCore.Mvc;
using Rozklad.Repository.Repositories;
using RozkladSchool.Models;
using System.Diagnostics;

namespace RozkladSchool.Controllers
{
    public class DayController : Controller
    {
        private readonly ILogger<DayController> _logger;
        private readonly DayRepository _dayRepository;
        public DayController(ILogger<DayController> logger, DayRepository dayRepository)
        {
            _logger = logger;
            _dayRepository = dayRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _dayRepository.GetDayAsync());
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
