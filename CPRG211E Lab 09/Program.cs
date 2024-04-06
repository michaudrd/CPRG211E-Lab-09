using MySqlConnector;

namespace DatabaseTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName);

            CourseManagerSQLite sqLiteDb = new CourseManagerSQLite();

            // Adding 5 courses
            Course course1 = new Course
            {
                CourseName = "Fundamentals of Web Development",
                Credits = 3
            };
            sqLiteDb.AddCourse(course1);

            Course course2 = new Course
            {
                CourseName = "Introduction to Full Stack Programming",
                Credits = 3
            };
            sqLiteDb.AddCourse(course2);

            Course course3 = new Course
            {
                CourseName = "Databases",
                Credits = 3
            };
            sqLiteDb.AddCourse(course3);

            Course course4 = new Course
            {
                CourseName = "Principles of Software Design and Analysis",
                Credits = 4
            };
            sqLiteDb.AddCourse(course4);

            Course course5 = new Course
            {
                CourseName = "Object-Oriented Programming",
                Credits = 4
            };
            sqLiteDb.AddCourse(course5);

            // Displaying the courses
            List<Course> coursesSqlite = sqLiteDb.GetAllCourses();
            foreach (var course in coursesSqlite)
            {
                Console.WriteLine(course);
            }


           


            ////Adding a student
            //StudentManagerSQLite sqLiteDb = new StudentManagerSQLite();
            //Student student3 = new Student
            //{
            //    Name = "Jane",
            //    Email = "Jane@sait.ca",
            //    Address = "999 Main Str. Calgary"
            //};
            //sqLiteDb.AddStudent(student3);
            //Console.WriteLine("Adding student has been completed");



            //foreach (var student in students)
            //{
            //    sqLiteDb.AddStudent(student);
            //}

            //sqLiteDb.DeleteStudent(12);
            //Console.WriteLine("Deleting student has been completed");


            //Console.WriteLine("\nDisplaying students in database");
            //List<Student> studentsSqlite = sqLiteDb.GetAllStudents();
            //foreach (var student in studentsSqlite)
            //{
            //    Console.WriteLine(student);
            //}

            //Console.WriteLine("\nUpdating student details");
            //Console.WriteLine(sqLiteDb.GetStudentById(6));
            //Student emily = sqLiteDb.GetStudentById(6);
            //emily.Address = "120 Main Str";
            //emily.Email = "emily@sait.ca";
            //sqLiteDb.UpdateStudent(emily);

            //Console.WriteLine("\nUpdate has been completed");
        }
    }
}
