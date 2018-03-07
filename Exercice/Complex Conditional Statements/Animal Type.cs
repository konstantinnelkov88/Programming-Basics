using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalType
{
    class Program
    {
        static void Main(string[] args)

        {
            var animal = Console.ReadLine().ToLower();

            if (animal != "dog" && animal != "tortoise" && animal != "crocodile" && animal != "snake")
            {
                Console.WriteLine("unknown");
            }
            else
            {
                if (animal == "dog") { Console.WriteLine("mammal"); }
                if (animal == "tortoise" || animal != "crocodile" || animal != "snake") { Console.WriteLine("reptile"); }
                
            }
        

        }
    }
}