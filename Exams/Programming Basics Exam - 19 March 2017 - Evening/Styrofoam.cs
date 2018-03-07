using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02Styrofoam
{
    class Problem02Styrofoam
    {
        static void Main(string[] args)
        {
            //Input
            var budget = double.Parse(Console.ReadLine());
            var HouseSquare = double.Parse(Console.ReadLine());
            var windows = byte.Parse(Console.ReadLine());
            var StyrofoamPerPackage = double.Parse(Console.ReadLine());
            var PackagePrice = double.Parse(Console.ReadLine());

            //Calculations
            var RealSquare = (HouseSquare - windows * 2.40) + (HouseSquare - windows * 2.40) * 0.1;
            var NeededMoneyForPackages = Math.Ceiling((RealSquare / StyrofoamPerPackage)) * PackagePrice;

            //Output
            if (budget >= NeededMoneyForPackages)
            {
                Console.WriteLine("Spent: {0:f2}", NeededMoneyForPackages);
                Console.WriteLine("Left: {0:f2}", budget - NeededMoneyForPackages);
            }
            else
            {
                Console.WriteLine("Need more: {0:f2}", NeededMoneyForPackages - budget);
            }
        }
    }
}