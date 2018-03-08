using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n == 1) { Console.WriteLine("Not prime"); }
            else if (n == 0) { Console.WriteLine("Not prime"); }
            else if (n < 0) { Console.WriteLine("Not prime"); }
            else
            {
                bool isPrime = true;

                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) { isPrime = false; }
                }

                if (isPrime == false) { Console.WriteLine("Not prime"); }
                else { Console.WriteLine("Prime"); }
            }
        }
    }
}