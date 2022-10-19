using Rozklad.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Dto.DayDto
{
   public class DayReadDto
    {
        public int DayId { get; set; }
        public string? DayName { get; set; }
        public ICollection<Timetable>? Timetables { get; set; }

    }
}
