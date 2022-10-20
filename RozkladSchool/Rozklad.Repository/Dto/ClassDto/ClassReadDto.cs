using Rozklad.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Dto.ClassDto
{
    public class ClassReadDto
    {
        public int ClassId { get; set; }
        public string? ClassName { get; set; }
       
        public ICollection<Timetable> Timetables { get; set; }
    }
}
