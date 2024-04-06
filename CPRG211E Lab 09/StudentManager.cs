using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace DatabaseTest
{
    public class StudentManager
    {
        private string connectionString;

        public StudentManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            using (var connection = new MySqlConnection())
            {
                connection.Open();

                var query = "SELECT * FROM students";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new Student
                            {
                                Id = Convert.ToInt32(reader["ID"]),
                                Name = reader["name"].ToString(),
                                Email = reader["email"].ToString(),
                                Address = reader["address"].ToString()
                            });
                        }
                    }
                }
            }
            return null;
        }
    }
}
