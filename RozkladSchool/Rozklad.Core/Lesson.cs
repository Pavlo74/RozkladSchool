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
        public string? LessonName { get; set; }
        public int Year { get; set; }
        public int DisciplineId { get; set; }
        public Discipline? Discipline { get; set; }
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }

        public int PupilId { get; set; }
        public Pupil? Pupil { get; set; }

        public virtual ICollection<Timetable>? Timetables { get; set; }
    }
}
