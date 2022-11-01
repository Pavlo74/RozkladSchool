using Microsoft.AspNetCore.Mvc;

namespace RozkladSchool.Controllers
{
    public class LessonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
