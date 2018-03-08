using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)

        {
            var n = int.Parse(Console.ReadLine());
            double minValue = double.Parse(Console.ReadLine());

            for (int i = 1; i <= n-1; i++)
            {
               double a = double.Parse(Console.ReadLine());
               if (a < minValue) { minValue = a; }
            }
            Console.WriteLine(minValue);
        }
    }
}