using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());

            var maxValue = double.Parse(Console.ReadLine());
            double sum = maxValue;
            double count = 1;
            for (int i = 1; i <= n-1; i++)
            {
                double a = double.Parse(Console.ReadLine());
                sum = sum + a;
                if (maxValue < a) 
                { 
                    maxValue = a;
                    count = i;
                }
               
            }
            sum = sum - maxValue;

            if (sum == maxValue)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", sum);
            }
            else
            {
                var diff = Math.Abs(maxValue - sum);
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", diff);
            }
            
        }
    }
}