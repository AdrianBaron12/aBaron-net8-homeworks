using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week40.Faculty1
{
    public class Student
    {
        public string FirstName;
        public string LastName;
        public int StudentId;
        public double GPA;

        public Student(string firstName, string lastName, int studentId, double gPA)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentId = studentId;
            GPA = gPA;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public bool HasHonors()
        {
            return GPA >= 3.5;
        }

        public string GetFirstName()
        {
            return FirstName;
        }
        public int GetStudentId()
        {
            return StudentId;
        }
        public string GetLastName()
        {
            return LastName;
        }
        public double GetGPA()
        {
            return GPA;
        }

        public void SetFirstName(string firstName)
        {
            FirstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            LastName = lastName;
        }
        public void SetStudentId(int studentId)
        {
            StudentId = studentId;
        }

        public void SetGPA(double gpa)
        {
            GPA = gpa;
        }

    }

    public class Faculty
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int employeeId { get; set; }
        List<string> subjectsTaught { get; set; }

        public Faculty(string firstname, string lastname, int employeeid, List<string> subjectstaught)
        {
            firstName = firstname;
            lastName = lastname;
            employeeId = employeeid;
            subjectsTaught = subjectstaught;
        }

        public string GetFullName()
        {
            return $"{firstName} {lastName}";
        }

        public List<string> GetSubjectsTaught()
        {
            return subjectsTaught;
        }
    }

    public class University
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Faculty> Faculties { get; set; }

        public University(string name)
        {
            Name = name;
            Students = new List<Student>();
            Faculties = new List<Faculty>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddFaculty(Faculty faculty)
        {
            Faculties.Add(faculty);
        }

        public int GetStudentCount()
        {
            return Students.Count;
        }

        public int GetFacultyCount()
        {
            return Faculties.Count;
        }

    }
}
