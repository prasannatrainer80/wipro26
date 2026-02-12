using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class C1
    {
        static C1()
        {
            Console.WriteLine("Base Class Static Constructor...");
        }
        public C1()
        {
            Console.WriteLine("Base Class Constructor...");
        }
    }

    class C2 : C1
    { 
        static C2()
        {
            Console.WriteLine("Derived Class Static Constructor...");
        }
        public C2()
        {
            Console.WriteLine("Derived Class Constructor...");
        }

        static void Main()
        {
            C2 c2 = new C2();
        }
    }
    
}
