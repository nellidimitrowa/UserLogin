using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository
{
    class StudentData
    {
        private static List<Student> _testStudents = new List<Student>();
        List<Student> TestStudents
        {
            get { addStudents(); return _testStudents; }
            private set;
        }

        private static void addStudents()
        {
            _testStudents.Add(new Student("Nedyalka", "Dimitrova", "Dimitrova", "FKST", "KSI", "bachelor", "certified", "121216065", 3, 1, 47, new DateTime(2019, 02, 01), new DateTime(2019, 02, 15)));
            _testStudents.Add(new Student("Yordan", "Atanasov", "Radkov", "FMI", "Informatics", "bachelor", "semester graduated", "121314001", 4, 0, 1, new DateTime(2018, 05, 01), new DateTime(2018,02, 15)));
        }

        public static Student findStudentByFacultyNumber(string fakNumber)
        {
            Student findedStudent = (from student in _testStudents
                                   where fakNumber.Equals(student.getFacNum())
                                   select student).First();
            return findedStudent;
        }
    }
}
