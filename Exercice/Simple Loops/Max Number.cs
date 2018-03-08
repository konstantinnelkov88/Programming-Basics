using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)

        {
            var n = int.Parse(Console.ReadLine());
            double maxValue = double.Parse(Console.ReadLine());

            for (int i = 1; i <= n-1; i++)
            {
               double a = double.Parse(Console.ReadLine());
               if (a > maxValue) { maxValue = a; }
            }
            Console.WriteLine(maxValue);
        }
    }
}