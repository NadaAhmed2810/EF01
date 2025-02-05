using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Data.Models
{
    //POCO 
    //Plain Old CLR Object

    internal class Employee
    {
        public int Id { get; set; }//Public Numeric Property Named  as Id or "ClassNameId" Will Be Considered Primary Key[Identity(1,1) ]
        public /*required*/  string? Name { get; set; }//Nullable Reference Type  [Allow Null ][Optional]
        public double Salary {  get; set; }//Non _Nullable Value Type :Not allow Null [Required]
        public int? Age { get; set; }//Nullable Value Type :Not allow Null [Optional]


    }
}
