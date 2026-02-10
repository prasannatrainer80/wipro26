using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Quiz6
    {
        int n;
        static void Main()
        {
            Quiz6 obj1 = new Quiz6();
            obj1.n = 12;
            Quiz6 obj2 = obj1;
            obj2.n = 13;
            Console.WriteLine(obj1.n);
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());
        }
    }
}
