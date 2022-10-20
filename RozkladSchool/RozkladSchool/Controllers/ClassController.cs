using Microsoft.AspNetCore.Mvc;
using Rozklad.Core;
using Rozklad.Repository.Dto.ClassDto;
using Rozklad.Repository.Repositories;
using RozkladSchool.Models;
using System.Diagnostics;

namespace RozkladSchool.Controllers
{
    public class ClassController : Controller
    {
        private readonly ILogger<ClassController> _logger;
        private readonly ClassRepository _classRepository;
        public ClassController(ILogger<ClassController> logger, ClassRepository classRepository)
        {
            _logger = logger;
            _classRepository = classRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _classRepository.GetClassAsync());
        }

        /*[HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(ClassCreateDto model)
        {
            if (ModelState.IsValid)
            {
                Class class = await classRepository.CreateClassAsync(model.ClassName);
                return RedirectToAction("Edit", "Users", new { id = class.Id});
            }
            return View(model);
        }*/

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

