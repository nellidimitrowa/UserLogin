using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository
{
    class StudentData
    {
        private static Student _testStudent = new Student();
        Student TestStudent
        {
            get { return _testStudent; }
            private set;
        }
    }
}
