using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05Parallelepiped
{
    class Problem05Parallelepiped
    {
        static void Main(string[] args)
        {
            //Input
            var n = byte.Parse(Console.ReadLine());

            //First Row
            Console.WriteLine("+{0}+{1}", new string('~', n - 2), new string('.', 2 * n + 1));

            //Second Row
            Console.WriteLine("|\\{0}\\{1}", new string('~', n - 2), new string('.', 2 * n));

            //Upper Part
            for (int i = 1; i <= 2 * n; i++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}", new string('.', i), new string('~', n - 2), new string('.', 2 * n - i));
            }

            //Bottom Part
            Console.WriteLine("\\{0}|{1}|", new string('.', 2 * n), new string('~', n - 2));

            for (int i = 1; i <= 2 * n; i++)
            {
                Console.WriteLine("{0}\\{1}|{2}|", new string('.', i), new string('.', 2 * n - i), new string('~', n - 2));
            }

            // Last Row
            Console.WriteLine("{0}+{1}+", new string('.', 2 * n + 1), new string('~', n - 2));
        }
    }
}