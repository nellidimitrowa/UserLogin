using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository
{
    public class Student
    {
        string firstName;
        string secondName;
        string lastName;
        string faculty;
        string speciality;
        string educationalDegree;
        string status;
        string facultyNumber;
        int course;
        int stream;
        int group;
        public DateTime lastAuthenticationDate;
        public DateTime lastSemesterFeeDate;

        public Student () { }
        public Student (string firstName, string secondName, string lastName, string faculty, string speciality, string educationalDegree,
            string status, string facultyNumber, int course, int stream, int group, DateTime lastAuthenticationDate, DateTime lastSemesterFeeDate)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.lastName = lastName;
            this.faculty = faculty;
            this.speciality = speciality;
            this.educationalDegree = educationalDegree;
            this.status = status;
            this.facultyNumber = facultyNumber;
            this.course = course;
            this.stream = stream;
            this.group = group;
            this.lastAuthenticationDate = lastAuthenticationDate;
            this.lastSemesterFeeDate = lastSemesterFeeDate;
        }

        public String GetFacNum()
        {
            return this.facultyNumber;
        }

        public override string ToString()
        {
            return "Names: " + firstName + " " + secondName + " " + lastName + "\nFaculty: " + faculty + "\nSpeciality: " + speciality +
                "\nEducational degree: " + educationalDegree + "\nStatus: " + status + "\nFaculty number: " + facultyNumber +
                "\nCourse: " + course + "\nStream: " + stream + "\nGroup: " + group + "\nDate of the last authentication date: " +
                lastAuthenticationDate + "\nDate of the last semester fee: " + lastSemesterFeeDate;
        }
    }
}
