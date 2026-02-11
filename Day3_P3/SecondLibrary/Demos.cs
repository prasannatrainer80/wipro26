using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLibrary
{
    internal class Demos : FirstLibrary.Training
    {
        public void Show()
        {
            Demos demos = new Demos();
            Console.WriteLine(demos.publicStr);
            Console.WriteLine(demos.protectedStr);
            Console.WriteLine(demos.internalProtectedStr);
        }
    }
}
