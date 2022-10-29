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

        public int DisciplineId { get; set; }
        public Discipline? Discipline { get; set; }

        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }

        public int LessonNumber { get; set; }
        public string? Day { get; set; }
        public string? TimeStart { get; set; }
        public string? TimeEnd { get; set; }
        public string? IconPath { get; set; }
        public int SectionId { get; set; }
        public Section? Section { get; set; }

        public int CabinetId { get; set; }
        public Cabinet? Cabinet { get; set; }

        
        
    }
}
