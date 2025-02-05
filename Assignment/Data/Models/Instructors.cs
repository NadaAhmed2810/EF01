using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    internal class Instructors
    {
        public int ID { get; set; }
        public  required string Name { get; set; }
        public decimal Salary { get; set; }
        public  string? Address { get; set; }
        public int HourRate { get; set; }
        public decimal Bouns { get; set; }
        public int Dept_ID { get; set; }
        

    }
}
