using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentRepository
{
    class StudentValidation
    {
        public Student GetStudentDataByUser (User user) 
        {
            Student student = StudentData.FindStudentByFacultyNumber(user.facultyNumber);
            if(user.facultyNumber == null || student == null)
            {
                Console.WriteLine("There is no student with this user's faculty number");
                return null;
            }
            return student;
        }
    }
}
