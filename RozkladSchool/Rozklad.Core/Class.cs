﻿using System.ComponentModel.DataAnnotations;

namespace Rozklad.Core
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        public string? ClassName { get; set; }

        //public int TimetableId { get; set; }
        //public Timetable? Timetable { get; set; }
    }
}