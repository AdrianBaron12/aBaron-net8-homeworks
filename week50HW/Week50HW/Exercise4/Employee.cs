using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPADV.Exercise4
{
    public abstract class Employee
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public abstract double CalculateBonus();

        public virtual string GetContactInfo()
        {
            return null;
        }
    }

    public enum Department
    {
        HR,
        IT,
        Sales,
        Marketing
    };

    public class Manager : Employee
    {
        private Department department;

        public Manager(string name, int age, double salary, Department department)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
            this.department = department;
        }

        public override double CalculateBonus()
        {
            return Salary * 0.1;
        }

        public override string GetContactInfo()
        {
            return $"Name: {Name}, Age: {Age}, Departament: {department}, email: {Name}@company.com, Phone:0111111111";
        }

    }

    public class Developer : Employee
    {
        public List<string> Skills { get; set; }
        public bool IsJunior { get; set; }

        public Developer(string name, int age, double salary, List<string> skills, bool isJunior)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
            this.Skills = skills;
            this.IsJunior = isJunior;
        }

        public override double CalculateBonus()
        {
            return Salary * 0.2;
        }

        public override string GetContactInfo()
        {
            return $"Name: {Name}, Age: {Age}, Skills: {Skills}, Email:{Name}@company.com, Phone:012222222";
        }

    }

}
