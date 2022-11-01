using Microsoft.AspNetCore.Mvc;
using Rozklad.Repository.Repositories;
using RozkladSchool.Models;
using System.Diagnostics;

namespace RozkladSchool.Controllers
{
    public class PupilController : Controller
    {
        private readonly ILogger<PupilController> _logger;
        private readonly PupilRepository _pupilRepository;
        public PupilController(ILogger<PupilController> logger, PupilRepository pupilRepository)
        {
            _logger = logger;
            _pupilRepository = pupilRepository;
        }

        public IActionResult Index()
        {
            return View(_pupilRepository.GetPupils());
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
