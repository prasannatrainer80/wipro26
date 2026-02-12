using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class First
    {
        public void Show()
        {
            Console.WriteLine("Show Method From Class First...");
        }
    }

    class Second : First
    { 
        public void Display()
        {
            Console.WriteLine("Display Method from Class Second...");
        }
    }
    internal class Inh1
    {
        static void Main()
        {
            Second second = new Second(); 
            second.Show();
            second.Display();
        }
    }

}
