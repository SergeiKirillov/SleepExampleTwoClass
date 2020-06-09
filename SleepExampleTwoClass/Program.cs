using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SleepExampleTwoClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 40);

            Thread task1 = new Thread(Class1.Pusk);
            task1.Start();

            Thread task2 = new Thread(Class2.Pusk);
            task2.Start();

            Console.ReadKey();
        }
    }
}
