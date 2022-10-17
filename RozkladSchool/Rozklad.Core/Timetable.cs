using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Core
{
    public class Timetable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TimetableId { get; set; }

        public int ClassId { get; set; }
        public virtual ICollection<Class>? Classes { get; set; }

        public int LessonId { get; set; }
        public virtual ICollection<Lesson>? Lessons { get; set; }

        public int DayId { get; set; }
        public virtual ICollection<Day>? Days { get; set; }

        public int DisciplineId { get; set; }
        public virtual ICollection<Discipline>? Disciplines { get; set; }

        public int CabinetId { get; set; }
        public virtual ICollection<Cabinet>? Cabinets { get; set; }
    }
}
