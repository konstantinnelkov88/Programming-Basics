using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)

        {
            var c = double.Parse(Console.ReadLine());

            double f = ((c / 5) * 9) + 32;

            Console.WriteLine(f);
     
        }
    }
}