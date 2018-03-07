using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)

        {
            var projection = Console.ReadLine();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (projection == "Premiere") { Console.WriteLine("{0:f2} leva", r*c*12); }
            if (projection == "Normal") { Console.WriteLine("{0:f2} leva", r * c * 7.5); }
            if (projection == "Discount") { Console.WriteLine("{0:f2} leva", r * c * 5); }
        }
    }
}