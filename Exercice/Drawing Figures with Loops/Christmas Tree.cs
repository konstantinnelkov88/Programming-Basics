using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} | {0}", new string(' ', n));
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1} | {1}{0}", new string(' ', n - i), new string('*', i));
            }
        }
    }
}