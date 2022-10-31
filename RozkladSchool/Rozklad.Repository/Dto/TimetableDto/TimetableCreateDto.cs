using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Dto.TimetableDto
{
    public class TimetableCreateDto
    {
        

        [Required]
        public string? ClassRoomName { get; set; }

        [Required]
        public string? CabinetName { get; set; }

        [Required]
        public string? DisciplineName { get; set; }

        [Required]
        public string? PupilName { get; set; }

        [Required]
        public string? TeacherName { get; set; }

        [Required]
        public int LessonNumber { get; set; }

        [Required]
        public string? Day { get; set; }

        [Required]
        public string? TimeStart { get; set; }

        [Required]
        public string? TimeEnd { get; set; }

        [Required]
        public decimal Price { get; set; }
       
        

       

       
    }
}
