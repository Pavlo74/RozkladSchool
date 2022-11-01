using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Core
{
    public class PupilLesson
    {
        [Key]
        public int PupilLessonId { get; set; }
        public int PupilId { get; set;}
        public Pupil? Pupil { get; set; }
        public int LessonId { get; set; }
        public Lesson? Lesson { get; set; }

    }
}
