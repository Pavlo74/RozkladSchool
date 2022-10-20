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
        public int LessonNumber { get; set; }
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }

        public ICollection<Timetable> Timetables { get; set; }
    }
}
