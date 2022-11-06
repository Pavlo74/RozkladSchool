using Microsoft.AspNetCore.Mvc;
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
        [BindProperty]
        public int LessonNumber { get; set; }
        [BindProperty]
        public string? Day { get; set; }
        [BindProperty]
        public string? TimeStart { get; set; }
        [BindProperty]
        public string? TimeEnd { get; set; }
        //public string? IconPath { get; set; }
        [BindProperty]
        public string? CabinetName { get; set; }
        [BindProperty]
        public string? DisciplineName { get; set; }
        [BindProperty]
        public string? TeacherName { get; set; }
        [BindProperty]
        public string? PupilName { get; set; }
        [BindProperty]
        public string? ClassRoomName { get; set; }
        [BindProperty]
        public string? LessonName { get; set; }
        [BindProperty]
        public string? UserId { get; set; }

    }
}
