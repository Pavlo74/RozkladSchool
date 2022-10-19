using Rozklad.Core;
using Rozklad.Repository.Dto.DayDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Repositories
{
  public class DayRepository
    {
        private readonly RozkladContext _ctx;
        public DayRepository(RozkladContext ctx)
        {
            _ctx = ctx;
        }


        public async Task<IEnumerable<DayReadDto>> GetDayTypesAsync()
        {
            var dayDto = _ctx.Days.
                Select(x => new DayReadDto
                {
                    DayId = x.DayId,
                    DayName=x.DayName,



                    Timetables = x.Timetables
                }).ToList();

            return dayDto;
        }
    }
}
