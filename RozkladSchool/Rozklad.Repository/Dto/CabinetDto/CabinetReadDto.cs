using Rozklad.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Dto.CabinetDto
{
   public class CabinetReadDto
    {

        public int CabinetId { get; set; }
        public string? Name { get; set; }

        public ICollection<Timetable>? Timetables { get; set; }
        
    }
}
