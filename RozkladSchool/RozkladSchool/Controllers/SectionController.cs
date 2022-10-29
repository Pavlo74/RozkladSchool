using Microsoft.AspNetCore.Mvc;
using Rozklad.Repository.Repositories;
using RozkladSchool.Models;
using System.Diagnostics;

namespace RozkladSchool.Controllers
{
    public class SectionController : Controller
    {
        private readonly ILogger<SectionController> _logger;
        private readonly SectionRepository _sectionRepository;
        public SectionController(ILogger<SectionController> logger, SectionRepository sectionRepository)
        {
            _logger = logger;
            _sectionRepository = sectionRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _sectionRepository.GetSectionAsync());
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
