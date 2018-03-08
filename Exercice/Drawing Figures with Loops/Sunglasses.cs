using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)

        {
            var n = int.Parse(Console.ReadLine());
            Console.Write(new string('*',2 * n));
            Console.Write(new string(' ',n));
            Console.WriteLine(new string('*',2 * n));
            int a = (n - 1) / 2 - 1;

            for (int i = 1; i <= n-2; i++)
            {
                Console.Write("*");
                Console.Write(new string('/', 2 * n-2));
                Console.Write("*");
                if (i == Math.Floor((double)(n - 1) / 2 )) 
                { 
                    Console.Write(new string('|', n)); 
                }
                else
                {
                    Console.Write(new string(' ', n));
                }
                Console.Write("*");
                Console.Write(new string('/', 2 * n - 2));
                Console.WriteLine("*");
            }
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
        }
    }
}