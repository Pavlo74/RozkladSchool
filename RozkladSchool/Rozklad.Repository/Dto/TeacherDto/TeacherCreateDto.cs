using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Dto.TeacherDto
{
    public class TeacherCreateDto
    {
        [Required(ErrorMessage = "Введіть назву")]
        [StringLength(32, ErrorMessage = "Must be between 1 and 32 characters", MinimumLength = 1)]
        [RegularExpression("^[a-zA-Z0-9_.-]", ErrorMessage = "Must be a valid name")]
        public string? TeacherName { get; set; }
    }
}
