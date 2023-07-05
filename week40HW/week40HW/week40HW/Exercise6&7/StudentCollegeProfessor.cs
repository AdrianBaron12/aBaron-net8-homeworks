using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week40.Faculty1;

namespace Week40.Faculty2
{
    public class College1
    {
        public string Name { get; set; }
        public int FounderYear { get; set; }
        public string City { get; set; }

        public College1()
        {
            Name = "Unknown";
            FounderYear = 0;
            City = "Unknown";
        }
    }

    public class Student1
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public College1 College { get; set; }
        public DateTime BirthDate { get; set; }

        public Student1(string name, DateTime startDate, DateTime endDate, College1 college, DateTime birthDate)
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

            return Convert.ToInt32(Now.Year - BirthDate.Year);
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

    public class Professor1
    {
        public string Name { get; set; }
        public string Faculty { get; set; }
        public string Specialization { get; set; }
        public List<Student1> StudentsWhoGiveTheirDegree { get; set; }

        public Professor1(string name, string faculty, string specialization)
        {
            Name = name;
            Faculty = faculty;
            Specialization = specialization;
            StudentsWhoGiveTheirDegree = new List<Student1>();
        }

        public Professor1(string name, string faculty, string specialization, List<Student1> studentsWhoGiveTheirDegree)
        {
            Name = name;
            Faculty = faculty;
            Specialization = specialization;
            StudentsWhoGiveTheirDegree = studentsWhoGiveTheirDegree;
        }


    }
}