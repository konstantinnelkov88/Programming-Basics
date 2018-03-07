using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcellentResult
{
    class Program
    {
        static void Main(string[] args)

        {
           decimal ocenka = decimal.Parse(Console.ReadLine());

            if (ocenka  >= (decimal) 5.5 )

            {
                Console.WriteLine("Excellent!");
            }

        }
    }
}