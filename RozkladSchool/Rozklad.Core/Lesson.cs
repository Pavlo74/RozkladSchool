using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Core
{
    public class Lesson
    {
        [Key]
        public int LessonId { get; set; }
        public int LessonNumber { get; set; }
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
        public virtual ICollection<Timetable> Timetables { get; set; }
        //public int TimetableId { get; set; }
        //public Timetable? Timetable { get; set; }
    }
}
