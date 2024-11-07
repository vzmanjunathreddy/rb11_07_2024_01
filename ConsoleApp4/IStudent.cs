using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public interface IStudent
    {
        decimal GetAverageGpa();
        IEnumerable<StudentModel> GetOrderedStudents();
        StudentModel GetHighestGpa();
    }
}
