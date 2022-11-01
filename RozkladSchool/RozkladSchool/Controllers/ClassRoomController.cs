using Microsoft.AspNetCore.Mvc;
using Rozklad.Repository.Repositories;
using RozkladSchool.Models;
using System.Diagnostics;

namespace RozkladSchool.Controllers
{
    public class ClassRoomController : Controller
    {
        /*private readonly ILogger<ClassRoomController> _logger;
        private readonly ClassRoomRepository _classRoomRepository;
        public ClassRoomController(ILogger<ClassRoomController> logger, ClassRoomRepository classRoomRepository)
        {
            _logger = logger;
            _classRoomRepository = classRoomRepository;
        }

        public IActionResult Index()
        {
            return View(_classRoomRepository.GetClasses());
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}
