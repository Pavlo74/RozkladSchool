using Microsoft.EntityFrameworkCore;
using Rozklad.Core;
using Rozklad.Repository.Dto.TimetableDto;


namespace Rozklad.Repository.Repositories
{
    public class TimetableRepository
    {
        private readonly RozkladContext _ctx;

        public TimetableRepository(RozkladContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Timetable> AddTimetableAsync(Timetable timetable)
        {
            _ctx.Timetables.Add(timetable);
            await _ctx.SaveChangesAsync();
            return _ctx.Timetables.Include(x => x.Lesson).ThenInclude(x => x.Teacher).Include(x => x.Lesson).ThenInclude(x => x.Discipline).Include(x => x.Lesson).ThenInclude(x => x.Pupil).
               Include(x => x.Cabinet).
               
               FirstOrDefault(x => x.Lesson.LessonName == timetable.Lesson.LessonName);
        }

        public Timetable GetTimetable(int id)
        {
            return _ctx.Timetables.Include(x => x.Lesson).ThenInclude(x => x.Teacher).Include(x => x.Lesson).ThenInclude(x => x.Discipline).Include(x => x.Lesson).ThenInclude(x => x.Pupil).
                Include(x => x.Cabinet).
                 FirstOrDefault(x => x.TimetableId == id);
        }

        public List<Timetable> GetTimetables()
        {
            var timetableList = _ctx.Timetables.Include(x => x.Lesson).ThenInclude(x => x.Teacher).Include(x => x.Lesson).ThenInclude(x => x.Discipline).Include(x => x.Lesson).ThenInclude(x => x.Pupil).
               Include(x => x.Cabinet).ToList();

            return timetableList;
        }

        public async Task<TimetableReadDto> GetTimetableDto(int id)
        {
            var v = await _ctx.Timetables.Include(x => x.Lesson).ThenInclude(x => x.Teacher).Include(x => x.Lesson).ThenInclude(x => x.Discipline).Include(x => x.Lesson).ThenInclude(x => x.Pupil).
               Include(x => x.Cabinet).FirstAsync(x => x.TimetableId == id);

            var timetableDto = new TimetableReadDto
            {
                TimetableId = v.TimetableId,
                LessonNumber = v.LessonNumber,
                Day = v.Day,
                TimeStart = v.TimeStart,
                TimeEnd = v.TimeEnd,
                LessonName = v.Lesson?.LessonName,
                CabinetName = v.Cabinet?.CabinetName,
                

            };
            return timetableDto;
        }

        public async Task DeleteTimetableAsync(int id)
        {
            _ctx.Remove(GetTimetable(id));
            await _ctx.SaveChangesAsync();
        }

        public async Task UpdateAsync(TimetableReadDto timetableDto, string cabinetName, string disciplineName,
           string classRoomName, string teacherName, string pupilName)
        {
            var timetable = _ctx.Timetables.Include(x => x.Lesson).ThenInclude(x => x.Teacher).Include(x => x.Lesson).ThenInclude(x => x.Discipline).Include(x => x.Lesson).ThenInclude(x => x.Pupil).
                 Include(x => x.Cabinet).FirstOrDefault(x => x.TimetableId == timetableDto.TimetableId);

            if (timetable.Cabinet.CabinetName != cabinetName)
                timetable.Cabinet = _ctx.Cabinets.FirstOrDefault(x => x.CabinetName == cabinetName);

            if (timetable.Lesson.Teacher.TeacherName != teacherName)
                timetable.Lesson.Teacher = _ctx.Teachers.FirstOrDefault(x => x.TeacherName == teacherName);

            if (timetable.Lesson.Discipline.DisciplineName != disciplineName)
                timetable.Lesson.Discipline = _ctx.Disciplines.FirstOrDefault(x => x.DisciplineName == disciplineName);

            if (timetable.Lesson.Pupil.PupilName != pupilName)
                timetable.Lesson.Pupil = _ctx.Pupils.FirstOrDefault(x => x.PupilName == pupilName);

            if (timetable.Day != timetableDto.Day)
                timetable.Day = timetableDto.Day;

            if (timetable.TimeStart != timetableDto.TimeStart)
                timetable.TimeStart = timetableDto.TimeStart;

            if (timetable.TimeEnd != timetableDto.TimeEnd)
                timetable.TimeEnd = timetableDto.TimeEnd;

            _ctx.SaveChanges();
        }

     }
}

