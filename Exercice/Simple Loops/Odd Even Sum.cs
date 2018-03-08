using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double sum1 = 0;
            double sum2 = 0;


            for (int i = 1; i <= n ; i++)
            {
                if (i % 2 == 1)
                {
                    sum1 = sum1 + double.Parse(Console.ReadLine());
                }
                else
                {
                    sum2 = sum2 + double.Parse(Console.ReadLine());
                }
            }
            if (sum1 == sum2) { Console.WriteLine("Yes Sum = {0}", sum1); }
            else { Console.WriteLine("No Diff = {0}", Math.Abs(sum1 -sum2)); }
        }
    }
}