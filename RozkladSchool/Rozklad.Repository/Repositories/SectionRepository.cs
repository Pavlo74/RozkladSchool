using Microsoft.EntityFrameworkCore;
using Rozklad.Core;
using Rozklad.Repository.Dto.SectionDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Repositories
{
    public class SectionRepository
    {
        private readonly RozkladContext _ctx;
        public SectionRepository(RozkladContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<IEnumerable<SectionReadDto>> GetSectionAsync()
        {
            var sectionDto = _ctx.Sections.
                Select(x => new SectionReadDto
                {
                    SectionId = x.SectionId,
                    SectionName = x.SectionName,
                    ClassId = x.ClassId,
                    Class = x.Class,
                    Timetables = x.Timetables
                }).ToList();

            return sectionDto;
        }

        public async Task<SectionReadDto> GetSectionAsync(int id)
        {
            var x = await _ctx.Sections.FirstAsync(x => x.SectionId == id);

            var secDto = new SectionReadDto
            {
                SectionId = x.SectionId,
                SectionName = x.SectionName,
                ClassId = x.ClassId,
                Class = x.Class,
                Timetables = x.Timetables
            };

            return secDto;
        }
    }
}
