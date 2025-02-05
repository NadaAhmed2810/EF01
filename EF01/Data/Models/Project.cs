using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Data.Models
{
    internal class Project
    {
        [Key]
        public int PNo {  get; set; }
        public required string PName { get; set; }
        public DateOnly CreationDate { get; set; }

    }
}
