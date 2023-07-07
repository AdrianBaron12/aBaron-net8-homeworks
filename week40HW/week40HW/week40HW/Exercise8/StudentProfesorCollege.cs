using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week40HW.Exercise6_7
{
    public class College1
    {
        public string Name;
        public int FoundedYear;
        public string City;

        public College1()
        {
            Name = "Unknown";
            FoundedYear = 0;
            City = "Unknown";
        }
    }

    public class Student1
    {
        public string Name;
        public DateTime StartDate;  
        public DateTime EndDate;
        public College1 College;
        public DateTime BirthDate;

        public bool IsStillStudent()
        {
            return EndDate > DateTime.Now;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Start Date: {StartDate.ToShortDateString()}");
            Console.WriteLine($"End Date: {EndDate.ToShortDateString()}");
            Console.WriteLine($"College: {College.Name}");
            Console.WriteLine($"Birth Date: {BirthDate.ToShortDateString()}");
            Console.WriteLine($"Is Still Student: {IsStillStudent()}");
            Console.WriteLine($"Age: {GetAge()}");
        }

        public Student1(string name, DateTime startDate, DateTime endDate, College1 college, DateTime birthDate)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            College = college;
            BirthDate = birthDate;
        }
    }

    public class Professor1
    {
        public string Name;
        public string Faculty;
        public string Specialization;
        public List<Student1> StudentsWhoGiveTheirDegree;

        public Professor1(string name, string faculty, string specialization)
        {
            Name = name;
            Faculty = faculty;
            Specialization = specialization;
            StudentsWhoGiveTheirDegree = new List<Student1>();
        }

        public Professor1(string name, string faculty, string specialization, List<Student1> students)
        {
            Name = name;
            Faculty = faculty;
            Specialization = specialization;
            StudentsWhoGiveTheirDegree = students;
        }
    }
}
