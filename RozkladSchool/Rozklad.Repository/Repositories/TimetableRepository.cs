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
            return _ctx.Timetables.Include(x => x.ClassRoom).ThenInclude(x => x.Pupil).Include(x => x.Discipline).ThenInclude(x => x.Teacher).
                Include(x => x.Cabinet).FirstOrDefault(x => x.ClassRoom.ClassRoomName == timetable.ClassRoom.ClassRoomName);
        }

        public Timetable GetTimetable(int id)
        {
            return _ctx.Timetables.Include(x => x.ClassRoom).ThenInclude(x => x.Pupil).Include(x => x.Discipline).ThenInclude(x => x.Teacher).
                Include(x => x.Cabinet).
                FirstOrDefault(x => x.TimetableId == id);
        }

        public List<Timetable> GetTimetables()
        {
            var timetableList = _ctx.Timetables.Include(x => x.ClassRoom).ThenInclude(x => x.Pupil).Include(x => x.Discipline).ThenInclude(x => x.Teacher).
                 Include(x => x.Cabinet).ToList();

            return timetableList;
        }

        public async Task<TimetableReadDto> GetTimetableDto(int id)
        {
            var v = await _ctx.Timetables.Include(x => x.ClassRoom).ThenInclude(x => x.Pupil).Include(x => x.Discipline).ThenInclude(x => x.Teacher).
            Include(x => x.Cabinet).FirstAsync(x => x.TimetableId == id);

            var timetableDto = new TimetableReadDto
            {
                TimetableId = v.TimetableId,
                PupilName = v.ClassRoom.Pupil.PupilName,
                TeacherName = v.Discipline.Teacher.TeacherName,
                LessonNumber = v.LessonNumber,
                Day = v.Day,
                TimeStart = v.TimeStart,
                TimeEnd = v.TimeEnd,
                CabinetName = v.Cabinet?.CabinetName,

            };
            return timetableDto;
        }

        public async Task DeleteTimetableAsync(int id)
        {
            _ctx.Remove(GetTimetable(id));
            await _ctx.SaveChangesAsync();
        }

    }
}

