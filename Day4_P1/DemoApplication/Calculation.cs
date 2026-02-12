using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class Input
    {
        public int a, b;

        public void ReadData()
        {
            Console.WriteLine("Enter 2 Numbers  ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Operations : Input
    {
        public void Sum()
        {
            int c = a + b;
            Console.WriteLine("Sum is  " +c);
        }

        public void Sub()
        {
            int c = a - b;
            Console.WriteLine("Sub is  " +c);
        }

        public void Mult()
        {
            int c = a * b;
            Console.WriteLine("Mult is  " +c);
        }
    }
    internal class Calculation
    {
        static void Main()
        {
            Operations operations = new Operations();
            operations.ReadData();
            operations.Sum();
            operations.Sub();
            operations.Mult();
        }
    }
}
