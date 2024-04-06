using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace DatabaseTest
{
    public class Student
    {

        [Required]
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
        public string Address { get; set; }

        public Student()
        {
        }

        public override string ToString()
        {
            return $"Id: {Id}\t" +
                $"Name: {Name}\t" +
                $"Email: {Email}\t" +
                $"Address: {Address}";
        }
    }
}
