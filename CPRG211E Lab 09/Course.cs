using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace DatabaseTest
{
    public class Course
    {
        [Required]
        [PrimaryKey, AutoIncrement]
        public int CourseId { get; set; }
        [Required]
        public string CourseName { get; set; }
        public int Credits { get; set; }

        public Course()
        {

        }

        public override string ToString()
        {
            return $"ID: {CourseId}\t" +
                   $"Course Name: {CourseName}\t" +
                   $"Credits: {Credits}";
        }
    }
}
