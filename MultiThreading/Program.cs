using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        public static void Main(string[] args)
        {
            Thread obj1 = new Thread(Function1);
            Thread obj2 = new Thread(Function2);
            obj1.IsBackground = true;
            obj2.IsBackground = true;
            obj1.Start();
            obj2.Start();
            Console.ReadLine();
        }
    }

    class ThreadProgram
    {
        static void Function1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Function i excuted " + i.ToString());
            }
        }

        static void Function2()
        {
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine("Function j excuted " + j.ToString());
            }
        }
    }
}
