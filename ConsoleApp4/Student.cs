using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Student : IStudent
    {
        public StudentModel GetHighestGpa()
        {
            var student = students.OrderByDescending(student => student.GPA).FirstOrDefault();

            return student!;
        }
        public IEnumerable<StudentModel> GetOrderedStudents()
        {
            return students.OrderBy(student => student.Age);
        }
        public decimal GetAverageGpa()
        {
            return students.Average(student => student.GPA);
        }

        private readonly IEnumerable<StudentModel> students = new List<StudentModel>()
        { new(){Age = 1, GPA = 10, Name = "test"},new(){Age = 12, GPA = 100, Name = "test2"},new(){Age = 9, GPA = 1000, Name = "test3"}};
    }
}
