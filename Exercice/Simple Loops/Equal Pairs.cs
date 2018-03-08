using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)

        {
            var n = int.Parse(Console.ReadLine());
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var sum1 = a + b;
            var sum = 0;
            var maxdiff = 0;
            if (n == 1) { Console.WriteLine("Yes, value={0}", sum1); }
            else
            {
                for (int i = 1; i <= n - 1; i++)
                {
               
                    sum = int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine());
                   
                    if (sum != sum1 && Math.Abs(sum - sum1) > maxdiff)
                    {
                        maxdiff = Math.Abs(sum - sum1);
                        sum1 = sum;
                        Console.WriteLine("maxdiff = {0}", maxdiff);
                    }
                    else
                    {
                        sum1 = sum;
                        Console.WriteLine("maxdiff = {0}", maxdiff);
                    }

                }
            }
            
            if (maxdiff != 0) { Console.WriteLine("No, maxdiff={0}", maxdiff); }
            else
            {
                Console.WriteLine("Yes, value={0}",sum1);
            }
        }
    }
}