using Rozklad.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Dto.TimetableDto
{
    public class TimetableReadDto
    {
        public int TimetableId { get; set; }

        public int ClassId { get; set; }
        public Class Class{ get; set; }

        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }

        public int DayId { get; set; }
        public Day Day { get; set; }

        public string IconPath { get; set; }

        public int DisciplineId { get; set; }
        public Discipline Discipline { get; set; }

        public int CabinetId { get; set; }
        public Cabinet Cabinet { get; set; }
    }
}
