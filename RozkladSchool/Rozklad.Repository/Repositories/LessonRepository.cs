using Rozklad.Core;
using Rozklad.Repository.Dto.LessonDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Repositories
{
    public class LessonRepository
    {

        private readonly RozkladContext _ctx;
        public LessonRepository(RozkladContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<LessonReadDto>> GetFuelTypesAsync()
        {
            var lessonDto = _ctx.Lessons.
                Select(x => new LessonReadDto
                {
                    LessonId = x.LessonId,
                    LessonNumber = x.LessonNumber,
                    StartTime = x.StartTime,
                    EndTime=x.EndTime,


                    Timetables = x.Timetables
                }).ToList();

            return lessonDto;
        }
    }
}
