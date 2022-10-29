using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rozklad.Core;

namespace Rozklad.Repository.Dto.TeacherDto
{
    public class TeacherReadDto
    {
        public int TeacherId { get; set; }
        public string? TeacherName { get; set; }
        public virtual ICollection<Timetable>? Timetables { get; set; }
    }
}
