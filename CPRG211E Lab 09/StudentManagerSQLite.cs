using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace DatabaseTest
{
    public class StudentManagerSQLite
    {
        private SQLiteConnection database;
        public StudentManagerSQLite()
        {
            // Instantiating the connection object with the path to the database
            // Path to the database is specified in Constant.cs
            this.database = new SQLiteConnection(Constants.DatabasePath);

            // Replaces SQL query to create a table for student
            this.database.CreateTable<Student>();
        }

        // Adding a student
        public void AddStudent(Student student)
        {
            this.database.Insert(student);
        }

        // Deleting a student
        public void DeleteStudent(int id)
        {
            this.database.Delete<Student>(id);
        }

        // Getting all students
        public List<Student> GetAllStudents()
        {
            return this.database.Table<Student>().ToList();
        }

        // Updating a student
        public void UpdateStudent(Student student)
        {
            this.database.Update(student);
        }

        // Getting a student by ID
        public Student GetStudentById(int id)
        {
            return this.database.Table<Student>()
                .Where(s => s.Id == id).FirstOrDefault();
        }

    }
}
