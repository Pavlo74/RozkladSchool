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

        public int LessonNumber { get; set; }
        public string? Day { get; set; }
        public string? TimeStart { get; set; }
        public string? TimeEnd { get; set; }
        public string? IconPath { get; set; }
        
        public string? CabinetName { get; set; }
        public string? DisciplineName { get; set; }
        public string? TeacherName { get; set; }
        public string? PupilName { get; set; }
        public string? ClassRoomName { get; set; }
        public string? LessonName { get; set; }
        public string? UserId { get; set; }

    }
}
