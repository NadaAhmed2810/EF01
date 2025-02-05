using Assignment.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data
{
    internal class ITIDbContext:DbContext 
    {
        public ITIDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Student>Students  { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Stud_Course> Crs_Std { get; set; }
        public DbSet<Topic>Topics { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Instructors> instructors { get; set; }

    }
}
