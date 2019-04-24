using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository
{
    public class StudentData
    {
        private static List<Student> _testStudents = new List<Student>();
        public static List<Student> TestStudents
        {
            get { AddStudents(); return _testStudents; }
            private set { }
        }

        private static void AddStudents()
        {
            _testStudents.Add(new Student("Nedyalka", "Dimitrova", "Dimitrova", "FKST", "KSI", "bachelor", "certified", "121212605", 3, 1, 47, new DateTime(2019, 02, 01), new DateTime(2019, 02, 15)));
            _testStudents.Add(new Student("Yordan", "Atanasov", "Radkov", "FMI", "Informatics", "bachelor", "semester graduated", "121314001", 4, 0, 1, new DateTime(2018, 05, 01), new DateTime(2018,02, 15)));
        }

        public static Student FindStudentByFacultyNumber(string fakNumber)
        {
            Student findedStudent = (from student in TestStudents
                                   where fakNumber.Equals(student.GetFacNum())
                                   select student).FirstOrDefault();
            return findedStudent;
        }
    }
}
