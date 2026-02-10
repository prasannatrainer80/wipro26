using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class StrDemo
    {
        static void Main()
        {
            string s1 = "Harsh", s2 = "Abhishek", s3 = "Vinay", s4 = "Harsh";
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s3.GetHashCode());
            Console.WriteLine(s4.GetHashCode());
        }
    }
}
