using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Core
{
    public class Section
    {
        [Key]
        public int SectionId { get; set; } 
        public string? SectionName { get; set; }
        public int ClassId { get; set; }
        public Class? Class { get; set; }

        public virtual ICollection<Timetable>? Timetables { get; set; }
        public virtual ICollection<Pupil>? Pupils { get; set; }
    }
}
