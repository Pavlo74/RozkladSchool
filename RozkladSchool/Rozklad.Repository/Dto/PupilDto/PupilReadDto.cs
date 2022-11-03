using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rozklad.Core;

namespace Rozklad.Repository.Dto.PupilDto
{
    public class PupilReadDto
    {
        public int PupilId { get; set; }
        public string? PupilName { get; set; }
        public int Year { get; set; }
        public int ClassRoomId { get; set; }
        public ClassRoom? ClassRoom { get; set; }
        public string? IconPath { get; set; }
    }
}
