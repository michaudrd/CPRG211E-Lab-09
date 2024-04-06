using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace DatabaseTest
{
    public class CourseManagerSQLite
    {
        private SQLiteConnection database;
        public CourseManagerSQLite()
        {
            // Instantiating the connection object with the path to the database
            // The path to the database is specified in Constant.cs
            this.database = new SQLiteConnection(Constants.DatabasePath);

            // Replaces SQL query to create a table for Course
            this.database.CreateTable<Course>();
        }

        // Adding a course
        public void AddCourse(Course course)
        {
            this.database.Insert(course);
        }

        // Deleting a course
        public void DeleteCourse(int courseId)
        {
            this.database.Delete<Course>(courseId);
        }

        // Updating a course
        public void UpdateCourse(Course course)
        {
            this.database.Update(course);
        }

        // Getting all courses
        public List<Course> GetAllCourses()
        {
            return this.database.Table<Course>().ToList();
        }

        // Getting a course by ID
        public Course GetCourseById(int id)
        {
            return this.database.Table<Course>()
                .Where(c => c.CourseId == id).FirstOrDefault();
        }
    }
}

