using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter faculty number: ");
            string facultyNumber = Console.ReadLine();
            Student student = StudentData.FindStudentByFacultyNumber(facultyNumber);
            if (student != null)
            {
                Console.WriteLine(student);
            }
            else
            {
                Console.WriteLine("There is no student with this faculty number. ");
            }
            Console.ReadKey();
        }
    }
}
