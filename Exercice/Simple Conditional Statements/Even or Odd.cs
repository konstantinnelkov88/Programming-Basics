using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)

        {
            var number = decimal.Parse(Console.ReadLine());

            if (number % 2 == 0 )
            {
                Console.WriteLine("Even");
            }

            else

            {
                Console.WriteLine("Odd");
            }

        }
    }
}
