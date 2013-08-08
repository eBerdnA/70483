﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1_1_1_L1_3
{
    class Program
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);

                Thread.Sleep(0);
            }
        }

        public static void Main(string[] args)
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(6);
            t.Join();

            Console.ReadKey();
        }
    }
}
