using Rozklad.Core;
using Rozklad.Repository.Dto.TimetableDto;


namespace Rozklad.Repository.Repositories
{
    public class TimetableRepository
    {
        private readonly RozkladContext _ctx;

        public TimetableRepository(RozkladContext ctx /*CabinetRepository vehicleModelRepository, ClassRepository bodyTypeRepository*/)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<TimetableReadDto>> GetTimetableAsync()
        {
            var timetableDto = _ctx.Timetables
                .Select(x => new TimetableReadDto
                {
                    Class = x.Class,
                    Lesson = x.Lesson,
                    Day = x.Day,
                    //IconPath = x.IconPath,
                    Discipline = x.Discipline,
                    Cabinet = x.Cabinet}).ToList();

            return timetableDto;
        }
    }
}
