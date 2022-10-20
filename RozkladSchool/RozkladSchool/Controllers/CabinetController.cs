using Microsoft.AspNetCore.Mvc;
using Rozklad.Repository.Repositories;
using RozkladSchool.Models;
using System.Diagnostics;

namespace RozkladSchool.Controllers
{
    public class CabinetController : Controller
    {
        private readonly ILogger<CabinetController> _logger;
        private readonly CabinetRepository _cabinetRepository;
        public CabinetController(ILogger<CabinetController> logger, CabinetRepository cabinetRepository)
        {
            _logger = logger;
            _cabinetRepository = cabinetRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _cabinetRepository.GetCabinetAsync());
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
