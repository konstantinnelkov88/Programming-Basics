using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)

        {
            var n = int.Parse(Console.ReadLine());
            if (n == 2)
            {
                Console.Write(new string('*', 2));
                Console.WriteLine(new string('|', 2));
            }
            else
            {
                int a = 0;
                for (int i = 1; i <= (n+1)/2; i++)
                {
                    if (i == (n + 1) / 2) { Console.WriteLine(new string('*', n)); }
                    else
                    {
                      if (n % 2 == 0 && i == 1) { a = 2;}
                      if (n % 2 == 1 && i == 1) { a = 1; }
                      Console.Write(new string('-', (n - a) / 2));
                      Console.Write(new string('*',a));
                      Console.WriteLine(new string('-', (n - a) / 2));
                      a = a + 2;
                    }
                }
                for (int i = 1; i <= n/2; i++)
                {
                    Console.Write("|");
                    Console.Write(new string('*', n-2));
                    Console.WriteLine("|");
                }
            }
        }
    }
}