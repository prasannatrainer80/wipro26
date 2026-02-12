using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class Employ
    {
        public void Show()
        {
            Console.WriteLine("Show Method from Employ Class...");
        }
    }

    class PayRoll : Employ
    {
        public void Show()
        {
            base.Show();
            Console.WriteLine("Show Method from Payroll Class...");
        }
    }
    internal class BaseEx1
    {
        static void Main()
        {
            PayRoll payRoll = new PayRoll();
            payRoll.Show();
        }
    }
}
