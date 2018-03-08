using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            int sum = 0;
    
            while(true)
            {
                if(n !=0)
                {
                    sum = sum + n % 10;
                    n = n / 10;
                }
                else
                { break; }
            }

            Console.WriteLine(sum);
        }
    }
}