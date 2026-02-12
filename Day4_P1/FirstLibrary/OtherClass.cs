using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLibrary
{
    internal class OtherClass
    {
        public void Show()
        {
            MainClass mainClass = new MainClass();
            Console.WriteLine(mainClass.publicStr);
            Console.WriteLine(mainClass.internalStr);
            Console.WriteLine(mainClass.internalProtectedStr);
        }
    }
}
