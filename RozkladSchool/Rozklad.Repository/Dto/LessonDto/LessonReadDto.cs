using Rozklad.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Dto.LessonDto
{
    public class LessonReadDto
    {
        public int LessonId { get; set; }
        public string? LessonName { get; set; }
        public int Year { get; set; }
        
        public string? Discipline { get; set; }
       
        public string? Teacher { get; set; }
        
        
        public virtual ICollection<Timetable>? Timetables { get; set; }
    }
}
