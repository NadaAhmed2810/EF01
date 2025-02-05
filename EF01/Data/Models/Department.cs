using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Data.Models
{
    internal class Department
    {
        public int DepartmentId { get; set; }
        public required string Name { get; set; }
        public DateOnly CreationDate { get; set; }
    }
}
