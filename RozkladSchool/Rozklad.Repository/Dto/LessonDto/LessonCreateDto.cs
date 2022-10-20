using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Dto.LessonDto
{
    public class LessonCreateDto
    {
        [Required(ErrorMessage = "Введіть час")]
        [StringLength(3, ErrorMessage = "Must be between 5 and 16 characters", MinimumLength = 1)]
        
        public string? LessonNumber { get; set; }
        [Required]
        public string? StartTime { get; set; }
        [Required]
        public string? EndTime { get; set; }

    }
}
