using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week40.Faculty1;

namespace Week40.Faculty2
{
    public class College2
    {
        public string Name { get; set; }
        public int FounderYear { get; set; }
        public string City { get; set; }

        public College2()
        {
            Name = "Unknown";
            FounderYear = 0;
            City = "Unknown";
        }
    }

    public class Student2
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public College2 College { get; set; }
        public DateTime BirthDate { get; set; }

        public Student2(string name, DateTime startDate, DateTime endDate, College2 college, DateTime birthDate)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            College = college;
            BirthDate = birthDate;
        }

        public bool IsStillStudent()
        {
            return DateTime.Today > EndDate ? true : false;
        }

        public int GetAge()
        {
            DateTime Now = DateTime.Now;

            return (Now.Year - BirthDate.Year);
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Start Date: {StartDate.ToShortTimeString}");
            Console.WriteLine($"End Date: {EndDate.ToShortTimeString}");
            Console.WriteLine($"College: {College.Name}");
            Console.WriteLine($"Birth Date: {BirthDate.ToShortTimeString}");
            Console.WriteLine($"Is still a student: {IsStillStudent}");
            Console.WriteLine($"Age: {GetAge()}");
        }

    }

    public class Professor2
    {
        public string Name { get; set; }
        public College2 College { get; set; }
        public string Specialization { get; set; }
        public List<Student2> StudentsWhoGiveTheirDegree { get; set; }


        public Professor2(string name, College2 college, Student2 student, Professor2 professor)
        {
            if (student.College.Name != professor.College.Name)
            {
                throw new Exception("These guys are not at the same college");
            }
        }

        public Professor2(string name, College2 college2, string specialization)
        {
            Name = name;
            College = college2;
            Specialization = specialization;
            StudentsWhoGiveTheirDegree = new List<Student2>();
        }

        public Professor2(string name, College2 college2, string specialization, List<Student2> studentsWhoGiveTheirDegree)
        {
            Name = name;
            College = college2;
            Specialization = specialization;
            StudentsWhoGiveTheirDegree = studentsWhoGiveTheirDegree;
        }

        public void AddStudent(Student2 student)
        {
            StudentsWhoGiveTheirDegree.Add(student);
        }

    }
}