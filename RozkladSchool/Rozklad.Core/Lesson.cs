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
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        //public int TimetableId { get; set; }
        //public Timetable? Timetable { get; set; }
    }
}
