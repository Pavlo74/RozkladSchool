using Rozklad.Core;
using Rozklad.Repository.Dto.DisciplineDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Repositories
{
    public class DisciplineRepository
    {

        private readonly RozkladContext _ctx;
        public DisciplineRepository(RozkladContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<IEnumerable<DisciplineReadDto>> GetDisciplineAsync()
        {
            var disciplineDto = _ctx.Disciplines.
                Select(x => new DisciplineReadDto
                {
                   DisciplineId = x.DisciplineId,
                   DisciplineName = x.DisciplineName,



                    Timetables = x.Timetables
                }).ToList();

            return disciplineDto;
        }
    }
}
