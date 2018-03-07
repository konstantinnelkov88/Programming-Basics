using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            if (product != "banana" && product != "apple" && product != "orange" && product != "grapefruit" && product != "kiwi" && product != "pineapple" && product != "grapes")
            {
                Console.WriteLine("error");
            }
            else
            {
                if (day == "saturday" || day == "sunday")
                {
                    switch (product)
                    {
                        case "banana": Console.WriteLine("{0:f2}", quantity * 2.7); break;
                        case "apple": Console.WriteLine("{0:f2}", quantity * 1.25); break;
                        case "orange": Console.WriteLine("{0:f2}", quantity * 0.9); break;
                        case "grapefruit": Console.WriteLine("{0:f2}", quantity * 1.6); break;
                        case "kiwi": Console.WriteLine("{0:f2}", quantity * 3); break;
                        case "pineapple": Console.WriteLine("{0:f2}", quantity * 5.6); break;
                        case "grapes": Console.WriteLine("{0:f2}", quantity * 4.2); break;
                    }
                }
                else if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
                {
                    switch (product)
                    {
                        case "banana": Console.WriteLine("{0:f2}", quantity * 2.5); break;
                        case "apple": Console.WriteLine("{0:f2}", quantity * 1.2); break;
                        case "orange": Console.WriteLine("{0:f2}", quantity * 0.85); break;
                        case "grapefruit": Console.WriteLine("{0:f2}", quantity * 1.45); break;
                        case "kiwi": Console.WriteLine("{0:f2}", quantity * 2.7); break;
                        case "pineapple": Console.WriteLine("{0:f2}", quantity * 5.5); break;
                        case "grapes": Console.WriteLine("{0:f2}", quantity * 3.85); break;
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            
        }
    }
}