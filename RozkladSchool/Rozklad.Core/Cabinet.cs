﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Core
{
    public class Cabinet
    {
        [Key]
        public int CabinetId { get; set; }
        public string? Name { get; set; }
    }
}
