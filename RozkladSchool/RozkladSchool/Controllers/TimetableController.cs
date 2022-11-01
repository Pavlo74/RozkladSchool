using Microsoft.AspNetCore.Mvc;
using Rozklad.Core;
using Rozklad.Repository.Dto.TimetableDto;
using Rozklad.Repository.Repositories;
using RozkladSchool.Models;
using System.Diagnostics;

namespace RozkladSchool.Controllers
{
    public class TimetableController : Controller
    { 
        /*private readonly ILogger<TimetableController> _logger;
        private readonly TimetableRepository _timetableRepository;
        private readonly ClassRoomRepository _classRoomRepository;
        private readonly CabinetRepository _cabinetRepository;
        private readonly DisciplineRepository _disciplineRepository;
        private readonly TeacherRepository _teacherRepository;
        private readonly PupilRepository _pupilRepository;
        //private readonly SectionRepository _sectionRepository;
        public TimetableController(ILogger<TimetableController> logger, TimetableRepository timetableRepository, ClassRoomRepository classRoomRepository, CabinetRepository cabinetRepository,
            DisciplineRepository disciplineRepository, TeacherRepository teacherRepository, PupilRepository pupilRepository)
        {
            _logger = logger;
            _timetableRepository = timetableRepository;
            _classRoomRepository = classRoomRepository;
            _cabinetRepository = cabinetRepository;
            _disciplineRepository = disciplineRepository;
            _teacherRepository = teacherRepository;
            _pupilRepository = pupilRepository;
            //_sectionRepository = sectionRepository;
        }

        public IActionResult Index()
        {
            return View(_timetableRepository.GetTimetables());
        }

        public IActionResult AddRozklad()
        {
            ViewBag.Cabinets = _cabinetRepository.GetCabinets();
            ViewBag.Classes = _classRoomRepository.GetClasses();
            ViewBag.Disciplines = _disciplineRepository.GetDisciplines();
            ViewBag.Teachers = _teacherRepository.GetTeachers();
            ViewBag.Pupils = _pupilRepository.GetPupils();
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> AddRozklad(TimetableCreateDto timetableDto, string cabinetName, string className,
            string teacherName, string sectionName, string disciplineName, string pupilName)
        {
            ViewBag.Cabinets = _cabinetRepository.GetCabinets();
            ViewBag.Classes = _classRoomRepository.GetClasses();
            ViewBag.Disciplines = _disciplineRepository.GetDisciplines();
            ViewBag.Teachers = _teacherRepository.GetTeachers();
            ViewBag.Pupils = _pupilRepository.GetPupils();

            if (ModelState.IsValid)
            {
                var cabinet = _cabinetRepository.GetCabinetByName(cabinetName);
                if (cabinet == null)
                {
                    cabinet = new Cabinet() { CabinetName = cabinetName };
                    cabinet = await _cabinetRepository.AddCabinetAsync(cabinet);
                }

                var pupil = _pupilRepository.GetPupilByName(pupilName);
                if (pupil == null)
                {
                    pupil = new Pupil() { PupilName = pupilName };
                    pupil = await _pupilRepository.AddPupilAsync(pupil);
                }

                var clas = _classRoomRepository.GetClassByName(className);
                if (clas == null)
                {
                    clas = new ClassRoom() { ClassRoomName = className, Pupil = pupil };
                    clas = await _classRoomRepository.AddClassAsync(clas);
                }

                
                var teacher = _teacherRepository.GetTeacherByName(teacherName);
                if (teacher == null)
                {
                    teacher = new Teacher() { TeacherName = teacherName };
                    teacher = await _teacherRepository.AddTeacherAsync(teacher);
                }

                

               
                var discipline = _disciplineRepository.GetDisciplineByName(disciplineName);
                if (discipline == null)
                {
                    discipline = new Discipline() { DisciplineName = disciplineName, Teacher = teacher };
                    discipline = await _disciplineRepository.AddDisciplineAsync(discipline);
                }


                var timetable = await _timetableRepository.AddTimetableAsync(new Timetable
                {
                    Cabinet = cabinet,
                    Discipline = discipline,
                    ClassRoom = clas,
                    LessonNumber = timetableDto.LessonNumber,
                    Day = timetableDto.Day,
                    TimeStart = timetableDto.TimeStart,
                    TimeEnd = timetableDto.TimeEnd,

                });
                return RedirectToAction("Index", "Timetable", new { id = timetable.TimetableId });
            }
            return View(timetableDto);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            return View(await _timetableRepository.GetTimetableDto(id));
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            await _timetableRepository.DeleteTimetableAsync(id);
            return RedirectToAction("Index", "Home");
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


    
