using Rozklad.Core;
using Rozklad.Repository.Dto.PupilDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Repositories
{
    public class PupilRepository
    {
        private readonly RozkladContext _ctx;
        public PupilRepository(RozkladContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<IEnumerable<PupilReadDto>> GetPupilAsync()
        {
            var pupilDto = _ctx.Pupils.
                Select(x => new PupilReadDto
                {
                    PupilId = x.PupilId,
                    PupilName = x.PupilName,
                    SectionId = x.SectionId,
                    Section = x.Section
                    
                }).ToList();

            return pupilDto;
        }
    }
}
