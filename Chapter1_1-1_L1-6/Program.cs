using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1_1_1_L1_6
{
    class Program
    {
        public static ThreadLocal<int> _field =
            new ThreadLocal<int>(() =>
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + Thread.CurrentThread.ManagedThreadId);
                return Thread.CurrentThread.ManagedThreadId;
            });

        public static void Main(string[] args)
        {
            new Thread(() =>
            {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Thread A: {0}", i);
                }
            }).Start();

            new Thread(() =>
            {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Thread B: {0}", i);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
