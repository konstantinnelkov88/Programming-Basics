using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)

        {
            var town = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            double commission = 0;

            if (town != "sofia" && town!= "varna" && town!="plovdiv")
            {
                Console.WriteLine("error");
            }
            else
            {
                if ( quantity < 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    if (town == "sofia")
                    {
                        if (quantity >= 0 && quantity <= 500) { commission = 0.05; }
                        if (quantity > 500 && quantity <= 1000) { commission = 0.07; }
                        if (quantity > 1000 && quantity <= 10000) { commission = 0.08; }
                        if (quantity > 10000) { commission = 0.12; }
                    }
                    else if (town == "varna")
                    {
                        if (quantity >= 0 && quantity <= 500) { commission = 0.045; }
                        if (quantity > 500 && quantity <= 1000) { commission = 0.075; }
                        if (quantity > 1000 && quantity <= 10000) { commission = 0.10; }
                        if (quantity > 10000) { commission = 0.13; }
                    }
                    else if (town == "plovdiv")
                    {
                        if (quantity >= 0 && quantity <= 500) { commission = 0.055; }
                        if (quantity > 500 && quantity <= 1000) { commission = 0.08; }
                        if (quantity > 1000 && quantity <= 10000) { commission = 0.12; }
                        if (quantity > 10000) { commission = 0.145; }
                    }

                    Console.WriteLine("{0:f2}", commission * quantity);
                }

              
            }

        }
    }
}