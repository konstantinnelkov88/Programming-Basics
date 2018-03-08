using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)

        {
            var n = int.Parse(Console.ReadLine());
            double sum1 = 0;
            double sum2 = 0;

            for (int i = 1; i <= 2*n; i++)
            {
                if(i <= n)
                {
                    sum1 = sum1 + double.Parse(Console.ReadLine());

                }
                else
                {
                    sum2 = sum2 + double.Parse(Console.ReadLine());
                }
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum = {0}", sum1);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(sum1 - sum2));
            }

        }
    }
}