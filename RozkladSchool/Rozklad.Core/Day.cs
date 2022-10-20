using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Core
{
    public class Day
    {
        [Key]
        public int DayId { get; set; }
        public string? DayName { get; set; }
        public virtual ICollection<Timetable> Timetables { get; set; }
        //public int TimetableId { get; set; }
        //public Timetable? Timetable { get; set; }
    }
}
