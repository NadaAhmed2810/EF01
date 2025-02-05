using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    internal class Student
    {
        public int ID { get; set; }
        public required string FName  { get; set; }
        public required string LName { get; set; }
        public  string? Address { get; set; }
        public int Age { get; set; }
        public int Dep_Id {  get; set; }
    }
}
