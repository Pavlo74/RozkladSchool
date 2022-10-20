using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Dto.DisciplineDto
{
    public class DisciplineCreateDto
    {
        [Required(ErrorMessage = "Введіть назву")]
        [StringLength(16, ErrorMessage = "Must be between 5 and 16 characters", MinimumLength = 5)]
        [RegularExpression("[a-zA-Z]", ErrorMessage = "Невірні символи")]
        public string? DisciplineName { get; set; }
    }
}
