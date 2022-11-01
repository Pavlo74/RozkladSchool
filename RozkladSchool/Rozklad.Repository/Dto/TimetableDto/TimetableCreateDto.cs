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
        
        public int LessonNumber { get; set; }
        public string? Day { get; set; }
        public string? TimeStart { get; set; }
        public string? TimeEnd { get; set; }
        public string? IconPath { get; set; }

        public string? CabinetName { get; set; }

        public string? LessonName { get; set; }








    }
}
