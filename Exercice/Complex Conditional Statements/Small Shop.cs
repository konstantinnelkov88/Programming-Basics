using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            if (product == "coffee")
            {
                if (town == "sofia")
                {
                    Console.WriteLine(0.50 * quantity);
                }
                else if (town == "plovdiv")
                {
                    Console.WriteLine(0.40 * quantity);
                }
                else if (town == "varna")
                {
                    Console.WriteLine(0.45 * quantity);
                }
            }
            if (product == "water")
            {
                if (town == "sofia")
                {
                    Console.WriteLine(0.80 * quantity);
                }
                else if (town == "plovdiv")
                {
                    Console.WriteLine(0.70 * quantity);
                }
                else if (town == "varna")
                {
                    Console.WriteLine(0.70 * quantity);
                }
            }
            if (product == "beer")
            {
                if (town == "sofia")
                {
                    Console.WriteLine(1.20 * quantity);
                }
                else if (town == "plovdiv")
                {
                    Console.WriteLine(1.15 * quantity);
                }
                else if (town == "varna")
                {
                    Console.WriteLine(1.10 * quantity);
                }
            }
            if (product == "sweets")
            {
                if (town == "sofia")
                {
                    Console.WriteLine(1.45 * quantity);
                }
                else if (town == "plovdiv")
                {
                    Console.WriteLine(1.30 * quantity);
                }
                else if (town == "varna")
                {
                    Console.WriteLine(1.35 * quantity);
                }
            }
            if (product == "peanuts")
            {
                if (town == "sofia")
                {
                    Console.WriteLine(1.60 * quantity);
                }
                else if (town == "plovdiv")
                {
                    Console.WriteLine(1.50 * quantity);
                }
                else if (town == "varna")
                {
                    Console.WriteLine(1.55 * quantity);
                }
            }
        }
    }
}