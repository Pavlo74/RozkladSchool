using Microsoft.AspNetCore.Mvc;
using Rozklad.Repository.Repositories;
using RozkladSchool.Models;
using System.Diagnostics;

namespace RozkladSchool.Controllers
{
    public class DisciplineController : Controller
    {
        private readonly ILogger<DisciplineController> _logger;
        private readonly DisciplineRepository _disciplineRepository;
        public DisciplineController(ILogger<DisciplineController> logger, DisciplineRepository disciplineRepository)
        {
            _logger = logger;
            _disciplineRepository = disciplineRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _disciplineRepository.GetDisciplineAsync());
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
