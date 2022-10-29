using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rozklad.Core;

namespace Rozklad.Repository.Dto.SectionDto
{
    public class SectionReadDto
    {
        public int SectionId { get; set; }
        public string? SectionName { get; set; }
        public int ClassId { get; set; }
        public Class? Class { get; set; }

        public virtual ICollection<Timetable>? Timetables { get; set; }
        public virtual ICollection<Pupil>? Pupils { get; set; }
    }
}
