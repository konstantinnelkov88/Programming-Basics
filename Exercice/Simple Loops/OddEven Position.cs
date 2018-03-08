using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            double sum_chetni = 0;
            double sum_nechetni = 0;
            double maxValue_n = int.MinValue;
            double maxValue_ch = int.MinValue;
            double minValue_n = int.MaxValue;
            double minValue_ch = int.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    double a = double.Parse(Console.ReadLine());
                    sum_chetni = sum_chetni + a;
                    if (maxValue_ch < a) { maxValue_ch = a; }
                    if (minValue_ch > a) { minValue_ch = a; }

                }
                if (i % 2 == 1)
                {
                    double a = double.Parse(Console.ReadLine());
                    sum_nechetni = sum_nechetni + a;
                    if (maxValue_n < a) { maxValue_n = a; }
                    if (minValue_n > a) { minValue_n = a; }
                }
            }
            if (n == 0)
            {
                Console.WriteLine("Oddsum = 0, Oddmin = No, Oddmax = No, Evensum = 0, Evenmin = No, Evenmax = No");
            }
            else if (n == 1)
            {
                Console.WriteLine("Oddsum = {0}, Oddmin = {1}, Oddmax = {2}, Evensum = 0, Evenmin = No, Evenmax = No", sum_nechetni, minValue_n, maxValue_n);
            }
            else
            {
                Console.WriteLine("Oddsum = {0}, Oddmin = {1}, Oddmax = {2}, Evensum = {3}, Evenmin = {4}, Evenmax = {5}", sum_nechetni, minValue_n, maxValue_n, sum_chetni, minValue_ch, maxValue_ch);
            }
        }
    }
}