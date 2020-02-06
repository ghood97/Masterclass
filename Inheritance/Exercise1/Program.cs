using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise1
{
    class Employee
    {
        private string name;
        private decimal salary;

        public Employee(string n, decimal s)
        {
            this.name = n;
            this.salary = s;
        }

        public virtual string DisplayInfo()
        {
            return "Name: " + this.name + "\nSalary: " + this.salary;
        }
    }

    class Manager : Employee
    {
        private string department;

        public Manager(string n, decimal s, string d)
            :base(n, s)
        {
            this.department = d;
        }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + "\nDepartment: " + this.department;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee("Griff", 80000);
            Console.WriteLine(e1.DisplayInfo());
            Console.WriteLine("----------------------");
            Manager m1 = new Manager("Gooch", 100000, "Engineering");
            Console.WriteLine(m1.DisplayInfo());

            Console.ReadKey();
        }
    }
}
