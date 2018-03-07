using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcellentOrNot
{
    class Program
    {
        static void Main(string[] args)

        {
           decimal evaluation = decimal.Parse(Console.ReadLine());

            if (evaluation  >= (decimal) 5.5 )

            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }

        }
    }
}