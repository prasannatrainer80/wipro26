using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class Employee
    {
        int empno;
        string name;
        double basic;

        public Employee(int empno, string name, double basic)
        {
            this.empno = empno;
            this.name = name;
            this.basic = basic;
        }

        public override string ToString()
        {
            return $"Employ No {empno} Employ Name {name} Basic {basic}";
        }
    }

    class Ganesh : Employee
    {
        public Ganesh(int empno, string name, double basic) : base(empno, name, basic)
        {
        }
    }
    class Pranav : Employee
    {
        public Pranav(int empno, string name, double basic) : base(empno, name, basic)
        {
        }
    }
    internal class BaseConEx
    {
        static void Main()
        {
            //Employee emp1 = new Ganesh(1, "Ganesh",88423.22);
            //Employee emp2 = new Pranav(2, "Pranav", 87722.11);

            //Console.WriteLine(emp1);
            //Console.WriteLine(emp2);

            Employee[] employees = new Employee[]
            {
                new Ganesh(1, "Ganesh",88423.22),
                new Pranav(2, "Pranav", 87722.11)
            };

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
