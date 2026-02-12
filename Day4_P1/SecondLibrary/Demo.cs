using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstLibrary;

namespace SecondLibrary
{
    public class Demo
    {
        public void Show()
        {
            MainClass mainClass = new MainClass();
            Console.WriteLine(mainClass.publicStr);
        }
    }
}
