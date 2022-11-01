using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Core
{
    public class ClassRoom
    {
        [Key]
        public int ClassRoomId { get; set; }
        public string? ClassRoomName { get; set; }
        public int Year { get; set; }

        public virtual ICollection<Pupil>? Pupils { get; set; }
        public virtual ICollection<Timetable>? Timetables { get; set; }
    }
}
