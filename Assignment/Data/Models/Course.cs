using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public  required string Name { get; set; }
        public string? Description { get; set; }
        public string? Duration { get; set; }
        public int Top_ID { get; set; }
    }
}
