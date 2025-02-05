using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Data.Models
{
    internal class Product
    {
        [Key]
        public int Code { get; set; }
        public required string NameAr { get; set; }
        public required string NameEn { get; set; }
        public double UnitPrice {  get; set; }




    }
}
