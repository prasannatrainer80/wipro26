using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class SbExNew
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("Students\n");
            sb.AppendLine("Neerav");
            sb.AppendLine("Uday");
            sb.AppendLine("Aman");
            sb.AppendLine("Vinay");
            sb.AppendLine("Tushar");
            Console.WriteLine(sb);
        }
    }
}
