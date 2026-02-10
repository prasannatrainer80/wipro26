using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class SbExample
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("Welcome to C# Programming...");
            Console.WriteLine(sb);
            sb.Insert(5, "Ritwak");
            Console.WriteLine(sb);
            sb.Remove(5, 6);
            Console.WriteLine(sb);
            sb.Append(" Tushar");
            Console.WriteLine(sb);
        }
    }
}
