using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    abstract class Student
    {
        int sid;
        string name;
        double cgpa;

        public Student(int sid, string name, double cgpa)
        {
            this.sid = sid;
            this.name = name;
            this.cgpa = cgpa;
        }

        public override string ToString()
        {
            return $"Sid {sid} Name {name} Cgpa {cgpa}";
        }
    }

    class Vinay : Student
    {
        public Vinay(int sid, string name, double cgpa) : base(sid, name, cgpa)
        {
        }
    }
    class Simha : Student
    {
        public Simha(int sid, string name, double cgpa) : base(sid, name, cgpa)
        {
        }
    }
    class Kabir : Student
    {
        public Kabir(int sid, string name, double cgpa) : base(sid, name, cgpa)
        {
        }
    }
    internal class AbsCon
    {
        static void Main()
        {
            Student[] arr = new Student[] { 
                new Kabir(1,"Kabir",8.3),
                new Simha(2,"Simha",9.1),
                new Vinay(3, "Vinay",9.3)
            };

            foreach(Student s in arr)
            {
                Console.WriteLine(s);
            }
        }
    }
}
