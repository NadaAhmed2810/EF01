﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    internal class Course_Inst
    {
        [Key]

        public int Inst_ID { get; set; }
        public int Course_ID { get; set; }
        public int evaluate {  get; set; }  
    }
}
