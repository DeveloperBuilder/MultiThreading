using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreading
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread obj1 = new Thread(ThreadProgram.Function1);
            Thread obj2 = new Thread(ThreadProgram.Function2);
            obj1.IsBackground = true;
            obj2.IsBackground = true;
            obj1.Start();
            obj2.Start();
            Console.ReadLine();
        }
    }

    public class ThreadProgram
    {
        public static void Function1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Function1 i excuted " + i.ToString());
            }
        }

        public static void Function2()
        {
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine("Function2 j excuted " + j.ToString());
            }
        }
    }
}
