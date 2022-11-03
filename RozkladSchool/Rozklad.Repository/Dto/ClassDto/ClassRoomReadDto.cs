using Rozklad.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Dto.ClassDto
{
    public class ClassRoomReadDto
    {
        public int ClassRoomId { get; set; }
        public string? ClassRoomName { get; set; }
        public int Year { get; set; }
        public int PupilId { get; set; }
        public Pupil? Pupil { get; set; }

        public virtual ICollection<Timetable>? Timetables { get; set; }
    }
}
