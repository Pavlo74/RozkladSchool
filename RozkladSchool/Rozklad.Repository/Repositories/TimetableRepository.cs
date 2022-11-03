using Microsoft.EntityFrameworkCore;
using Rozklad.Core;
using Rozklad.Repository.Dto.TimetableDto;


namespace Rozklad.Repository.Repositories
{
    public class TimetableRepository
    {
        private readonly RozkladContext _ctx;
        private readonly UsersRepository _usersRepository;
        public TimetableRepository(RozkladContext ctx, UsersRepository usersRepository)
        {
            _ctx = ctx;
            _usersRepository = usersRepository;
        }

        public async Task<Timetable> AddTimetableAsync(Timetable timetable)
        {
            _ctx.Timetables.Add(timetable);
            await _ctx.SaveChangesAsync();
            return _ctx.Timetables.Include(x => x.Lesson).ThenInclude(x => x.Teacher).Include(x => x.Lesson).ThenInclude(x => x.Discipline).Include(x => x.Lesson).ThenInclude(x => x.Pupil).
               Include(x => x.Cabinet).
               Include(x => x.User).

               FirstOrDefault(x => x.Lesson.LessonName == timetable.Lesson.LessonName);
        }

        public Timetable GetTimetable(int id)
        {
            return _ctx.Timetables.Include(x => x.Lesson).ThenInclude(x => x.Teacher).Include(x => x.Lesson).ThenInclude(x => x.Discipline).Include(x => x.Lesson).ThenInclude(x => x.Pupil).
                Include(x => x.Cabinet).
                Include(x => x.User).
                 FirstOrDefault(x => x.TimetableId == id);
        }

        public List<Timetable> GetTimetables()
        {
            var timetableList = _ctx.Timetables.Include(x => x.Lesson).ThenInclude(x => x.Teacher).Include(x => x.Lesson).ThenInclude(x => x.Discipline).Include(x => x.Lesson).ThenInclude(x => x.Pupil).
               Include(x => x.Cabinet).
               Include(x => x.User).ToList();

            return timetableList;
        }

        public async Task<TimetableReadDto> GetTimetableDto(int id)
        {
            var v = await _ctx.Timetables.Include(x => x.Lesson).ThenInclude(x => x.Teacher).Include(x => x.Lesson).ThenInclude(x => x.Discipline).Include(x => x.Lesson).ThenInclude(x => x.Pupil).
               Include(x => x.Cabinet).
               Include(x => x.User).FirstAsync(x => x.TimetableId == id);

            var timetableDto = new TimetableReadDto
            {
                TimetableId = v.TimetableId,
                LessonNumber = v.LessonNumber,
                Day = v.Day,
                TimeStart = v.TimeStart,
                TimeEnd = v.TimeEnd,
                
                TeacherName = v.Lesson.Teacher.TeacherName,
                PupilName = v.Lesson.Pupil.PupilName,
                LessonName = v.Lesson?.LessonName,
                CabinetName = v.Cabinet?.CabinetName,
                UserId = v.UserId


            };
            return timetableDto;
        }

      

        public async Task UpdateAsync(TimetableReadDto timetableDto, string cabinetName, string disciplineName,
           string classRoomName, string teacherName, string pupilName)
        {
            var timetable = _ctx.Timetables.Include(x => x.Lesson).ThenInclude(x => x.Teacher).Include(x => x.Lesson).ThenInclude(x => x.Discipline).Include(x => x.Lesson).ThenInclude(x => x.Pupil).
                 Include(x => x.Cabinet).
                 Include(x => x.User).FirstOrDefault(x => x.TimetableId == timetableDto.TimetableId);

            if (timetable.Cabinet.CabinetName != cabinetName)
                timetable.Cabinet = _ctx.Cabinets.FirstOrDefault(x => x.CabinetName == cabinetName);

            if (timetable.Lesson.Teacher.TeacherName != teacherName)
                timetable.Lesson.Teacher = _ctx.Teachers.FirstOrDefault(x => x.TeacherName == teacherName);

            if (timetable.Lesson.Discipline.DisciplineName != disciplineName)
                timetable.Lesson.Discipline = _ctx.Disciplines.FirstOrDefault(x => x.DisciplineName == disciplineName);

            if (timetable.Lesson.Pupil.PupilName != pupilName)
                timetable.Lesson.Pupil = _ctx.Pupils.FirstOrDefault(x => x.PupilName == pupilName);

            //if (timetable.Pupil.ClassRoom.ClassRoomName != classRoomName)
               // timetable.Pupil.ClassRoom = _ctx.ClassRooms.FirstOrDefault(x => x.ClassRoomName == classRoomName);

            if (timetable.Day != timetableDto.Day)
                timetable.Day = timetableDto.Day;

            if (timetable.LessonNumber != timetableDto.LessonNumber)
                timetable.LessonNumber = timetableDto.LessonNumber;

            if (timetable.TimeStart != timetableDto.TimeStart)
                timetable.TimeStart = timetableDto.TimeStart;

            if (timetable.TimeEnd != timetableDto.TimeEnd)
                timetable.TimeEnd = timetableDto.TimeEnd;

             _ctx.SaveChanges();
        }

        public async Task DeleteTimetableAsync(int id)
        {
            _ctx.Remove(GetTimetable(id));
            await _ctx.SaveChangesAsync();
        }
    }
}

