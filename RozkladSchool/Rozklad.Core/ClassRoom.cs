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
        public int PupilId { get; set; }
        public Pupil Pupil { get; set; }

        public virtual ICollection<Timetable>? Timetables { get; set; }
    }
}
