<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Mvc;
=======
﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Rozklad.Core;
using Rozklad.Repository;
using Rozklad.Repository.Dto.TimetableDto;
>>>>>>> admin
using Rozklad.Repository.Repositories;
using RozkladSchool.Models;
using System.Diagnostics;

namespace RozkladSchool.Controllers
{
    public class TimetableController : Controller
<<<<<<< HEAD
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
=======
    { 
        private readonly ILogger<TimetableController> _logger;
        private readonly TimetableRepository _timetableRepository;
        private readonly ClassRoomRepository _classRoomRepository;
        private readonly CabinetRepository _cabinetRepository;
        private readonly DisciplineRepository _disciplineRepository;
        private readonly TeacherRepository _teacherRepository;
        private readonly PupilRepository _pupilRepository;
        private readonly LessonRepository _lessonRepository;
        private readonly UsersRepository _usersRepository;

        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public TimetableController(ILogger<TimetableController> logger, TimetableRepository timetableRepository, ClassRoomRepository classRoomRepository, CabinetRepository cabinetRepository,
            DisciplineRepository disciplineRepository, TeacherRepository teacherRepository, UsersRepository usersRepository, UserManager<User> userManager, SignInManager<User> signInManager, PupilRepository pupilRepository, LessonRepository lessonRepository)
        {
            _logger = logger;
            _timetableRepository = timetableRepository;
            _classRoomRepository = classRoomRepository;
            _cabinetRepository = cabinetRepository;
            _disciplineRepository = disciplineRepository;
            _teacherRepository = teacherRepository;
            _pupilRepository = pupilRepository;
            _lessonRepository = lessonRepository;
            _usersRepository = usersRepository;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
>>>>>>> admin
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
            ViewBag.Lessons = _lessonRepository.GetLessons();
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> AddRozklad(TimetableCreateDto timetableDto, string cabinetName, string classRoomName,
            string teacherName, string lessonName, string disciplineName, string pupilName)
        {
            ViewBag.Cabinets = _cabinetRepository.GetCabinets();
            ViewBag.Classes = _classRoomRepository.GetClasses();
            ViewBag.Disciplines = _disciplineRepository.GetDisciplines();
            ViewBag.Teachers = _teacherRepository.GetTeachers();
            ViewBag.Pupils = _pupilRepository.GetPupils();
            ViewBag.Lessons = _lessonRepository.GetLessons();

            
                var cabinet = _cabinetRepository.GetCabinetByName(cabinetName);
                if (cabinet == null)
                {
                    cabinet = new Cabinet() { CabinetName = cabinetName };
                    cabinet = await _cabinetRepository.AddCabinetAsync(cabinet);
                }

                var discipline = _disciplineRepository.GetDisciplineByName(disciplineName);
                if (discipline == null)
                {
                    discipline = new Discipline() { DisciplineName = disciplineName };
                    discipline = await _disciplineRepository.AddDisciplineAsync(discipline);
                }

                var pupil = _pupilRepository.GetPupilByName(pupilName);
                if (pupil == null)
                {
                    pupil = new Pupil() { PupilName = pupilName };
                    pupil = await _pupilRepository.AddPupilAsync(pupil);
                }

                var user = _usersRepository.GetUserByEmail(User.Identity.Name);
                if (user == null)
                {
                    user = new User() { Email = User.Identity.Name };
                }

                var clas = _classRoomRepository.GetClassByName(classRoomName);
                if (clas == null)
                {
                    clas = new ClassRoom() { ClassRoomName = classRoomName };
                    clas = await _classRoomRepository.AddClassAsync(clas);
                }

                var teacher = _teacherRepository.GetTeacherByName(teacherName);
                if (teacher == null)
                {
                    teacher = new Teacher() { TeacherName = teacherName };
                    teacher = await _teacherRepository.AddTeacherAsync(teacher);
                }

                var lesson = _lessonRepository.GetLessonByName(lessonName);
                if (lesson == null)
                {
                    lesson = new Lesson() { LessonName = lessonName, Discipline = discipline, Teacher = teacher, Pupil = pupil };
                    lesson = await _lessonRepository.AddLessonAsync(lesson);
                }

                var timetable = await _timetableRepository.AddTimetableAsync(new Timetable
                {
                    Cabinet = cabinet,
                    Lesson = lesson,
                    //Pupil = pupil,
                    //ClassRoom = clas,
                    LessonNumber = timetableDto.LessonNumber,
                    Day = timetableDto.Day,
                    TimeStart = timetableDto.TimeStart,
                    TimeEnd = timetableDto.TimeEnd,
                    User = user

                });
                return RedirectToAction("Index", "Timetable", new { id = timetable.TimetableId });
            
            return View(timetableDto);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Cabinets = _cabinetRepository.GetCabinets();
            ViewBag.Classes = _classRoomRepository.GetClasses();
            ViewBag.Disciplines = _disciplineRepository.GetDisciplines();
            ViewBag.Teachers = _teacherRepository.GetTeachers();
            ViewBag.Pupils = _pupilRepository.GetPupils();
            ViewBag.Lessons = _lessonRepository.GetLessons();
            return View(await _timetableRepository.GetTimetableDto(id));
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(TimetableReadDto timetableDto, string cabinetName, string className,
            string teacherName, string lessonName, string disciplineName, string pupilName)
        {
            //if (ModelState.IsValid)
            //{
        await _timetableRepository.UpdateAsync(timetableDto, cabinetName, lessonName, disciplineName, teacherName, className);
            return RedirectToAction();
            //}
            ViewBag.Cabinets = _cabinetRepository.GetCabinets();
            ViewBag.Classes = _classRoomRepository.GetClasses();
            ViewBag.Disciplines = _disciplineRepository.GetDisciplines();
            ViewBag.Teachers = _teacherRepository.GetTeachers();
            ViewBag.Pupils = _pupilRepository.GetPupils();
            ViewBag.Lessons = _lessonRepository.GetLessons();
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
        }


    }
}


    
