using Rozklad.Core;
using Rozklad.Repository.Dto.TeacherDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Repositories
{
   public class TeacherRepository
    {
        private readonly RozkladContext _ctx;
        public TeacherRepository(RozkladContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<IEnumerable<TeacherReadDto>> GetTeacherAsync()
        {
            var teacherDto = _ctx.Teachers.
                Select(x => new TeacherReadDto
                {
                    TeacherId = x.TeacherId,
                    TeacherName = x.TeacherName,
                    Timetables = x.Timetables
                }).ToList();

            return teacherDto;
        }
    }
}
