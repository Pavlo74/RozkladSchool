using Rozklad.Core;
using Rozklad.Repository.Dto.CabinetDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Repositories
{
 public class CabinetRepository
    {
        private readonly RozkladContext _ctx;
        public CabinetRepository(RozkladContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<CabinetReadDto>> GetCabinetAsync()
        {
            var cabinetDto = _ctx.Cabinets.
                Select(x => new CabinetReadDto
                {
                   
                    CabinetId=x.CabinetId,
                    Name=x.Name,
                    Timetables=x.Timetables
                }).ToList();

            return cabinetDto;
        }

    }
}
