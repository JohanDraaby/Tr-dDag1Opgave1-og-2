using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrådDag1Opgave1
{
    class Threads
    {
        public static void ThreadsMain()
        {
            Thread threadPrint1 = new Thread(new ThreadStart(Print1));
            Thread threadPrint2 = new Thread(new ThreadStart(Print2));

            threadPrint1.Start();
            Thread.Sleep(100);
            threadPrint2.Start();

        }


        public static void Print1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("C#-Trådning Er Nemt!!!");
                Thread.Sleep(1000);
            }
            
        }

        public static void Print2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Også Med Flere Tråde!1!!");
                Thread.Sleep(1000);
            }
        }



    }
}
