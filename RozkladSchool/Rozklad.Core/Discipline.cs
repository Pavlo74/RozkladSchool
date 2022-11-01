using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Core
{
    public class Discipline
    {
        [Key]
        public int DisciplineId { get; set; }
        public string? DisciplineName { get; set; }
        public virtual ICollection<Lesson>? Lessons { get; set; }

    }
}
