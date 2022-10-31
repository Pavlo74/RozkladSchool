using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Core
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string? TeacherName { get; set; }
        public virtual ICollection<Discipline>? Disciplines { get; set; }
    }
}
