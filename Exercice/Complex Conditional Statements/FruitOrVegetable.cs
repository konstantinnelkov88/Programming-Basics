using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)

        {
           string ime = Console.ReadLine();


            if ( ime == "banana" || ime == "kiwi" || ime == "apple" || ime == "lemon" || ime == "grapes" || ime == "cherry" ) 
            {
                Console.WriteLine("fruit");
            }

            else if ( ime == "tomato" || ime == "cucumber" || ime == "pepper" || ime == "carrot" ) 
            {
                Console.WriteLine("Vegetable");
            }

            else

            {
                Console.WriteLine("unknown");
            }
        }
    }
}