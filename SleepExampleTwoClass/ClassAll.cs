using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SleepExampleTwoClass
{
    class ClassAll
    {
        int curX;
        public int CursorX
        {
            get { return curX; }
            set { curX = value; }
        }

        int curY;
        public int CursorY
        {
            get { return curY; }
            set { curY = value; }
        }


        public void PuskAll()
        {


            Thread q1 = new Thread(Query1c);
            q1.Start();

            Thread q100 = new Thread(Query100mc);
            q100.Start();

            Thread q101 = new Thread(Query101mc);
            q101.Start();

            Thread q200 = new Thread(Query200mc);
            q200.Start();
        }

        private void Query1c()
        {
            while (true)
            {
                Thread.Sleep(1000);
                Console.SetCursorPosition(curX, curY);
                Console.WriteLine("Sleep 1c - " + DateTime.Now.ToString("HH:mm:ss.fff"));
            }
        }

        private void Query100mc()
        {
            int i = curY+2;
            while (true)
            {
                Thread.Sleep(100);

                if (i < 12)
                {
                    Console.SetCursorPosition(curX, i);
                    Console.WriteLine("Sleep 100mc - " + DateTime.Now.ToString("HH:mm:ss.fff"));
                    i++;
                }
                else
                {
                    i = 2;
                }
                //Console.SetCursorPosition(0, 2);
                //Console.WriteLine("Sleep 100mc - " + DateTime.Now.ToString("HH:mm:ss.fff"));
            }
        }

        private void Query101mc()
        {
            int i = curY + 14;
            while (true)
            {
                Thread.Sleep(101);

                if (i < 24)
                {
                    Console.SetCursorPosition(curX, i);
                    Console.WriteLine("Sleep 101mc - " + DateTime.Now.ToString("HH:mm:ss.fff"));
                    i++;
                }
                else
                {
                    i = 14;
                }
                //Console.SetCursorPosition(0, 2);
                //Console.WriteLine("Sleep 100mc - " + DateTime.Now.ToString("HH:mm:ss.fff"));
            }
        }


        private void Query200mc()
        {

            while (true)
            {
                Thread.Sleep(200);

                Console.SetCursorPosition(curX, curY+26);
                Console.WriteLine("Sleep 200mc - " + DateTime.Now.ToString("HH:mm:ss.fff"));

            }
        }
    }
}
