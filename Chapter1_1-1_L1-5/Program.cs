using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1_1_1_L1_5
{
    class Program
    {
        //[ThreadStatic] // without this Attribute both threads access the same value
        public static int _field;

        public static void Main(string[] args)
        {
                    new Thread(() =>
               { 
                    for(int x = 0; x < 10; x++)
                    {
                        _field++;
                        Console.WriteLine("Thread A: {0}", _field);
                    }
                }).Start();
            new Thread(() =>
                { 
                    for(int x = 0; x < 10; x++)
                    {
                        _field++;
                        Console.WriteLine("Thread B: {0}", _field);
                    }
                }).Start();
            Console.ReadKey();
        }
    }        
}
