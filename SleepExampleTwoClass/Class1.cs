using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SleepExampleTwoClass
{
    class Class1
    {
        static public void Pusk()
        {
            ClassAll clall = new ClassAll();
            clall.CursorX = 0;
            clall.CursorY = 0;
            clall.PuskAll();
        }
    }
}
