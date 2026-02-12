using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    abstract class Training
    {
        public abstract void Name();
        public abstract void Email();
    }

    class Aman : Training
    {
        public override void Email()
        {
            Console.WriteLine("Email is Aman@gmail.com");
        }

        public override void Name()
        {
            Console.WriteLine("Hi I am Aman...");
        }
    }

    class Neerav : Training
    {
        public override void Email()
        {
            Console.WriteLine("Email is Neerav@gmail.com");
        }

        public override void Name()
        {
            Console.WriteLine("Hi I am Neerav Vivek...");
        }
    }

    class Ritwik : Training
    {
        public override void Email()
        {
            Console.WriteLine("Email is Ritwik@gmail.com");
        }

        public override void Name()
        {
            Console.WriteLine("Hi I am Ritwik...");
        }
    }
    internal class AbstEx1
    {
        static void Main()
        {
            //Training obj1 = new Ritwik();
            //Training obj2 = new Aman();
            //Training obj3 = new Neerav();

            Training[] arr = new Training[]
            {
                new Ritwik(), new Aman(), new Neerav()
            };

            foreach(Training training in arr)
            {
                training.Name();
                training.Email();
            }
        }
    }
}
