﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    internal class Stud_Course
    {

        [Key]
        public int Stud_ID { get; set; }
      
        public int Crs_ID { get; set; }
        public int Grade { get; set; }

    }
}
