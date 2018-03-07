using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04Bills
{
    class Problem04Bills
    {
        static void Main(string[] args)
        {
            //Input
            var Months = byte.Parse(Console.ReadLine());
            
            double Others = 0;
            double TotalElectricity = 0;
            for (int i = 1; i <= Months; i++)
            {
                var Electricity = double.Parse(Console.ReadLine());
                TotalElectricity = TotalElectricity + Electricity; 
                Others = Others + (Electricity + 20 + 15) + (Electricity + 20 + 15) * 0.2;
            }
            var ElectricityAverage = TotalElectricity / Months;
            var Water = Months * 20;
            var Internet = Months * 15;
            var Average = (TotalElectricity + Others + Water + Internet) / Months;

            //Output
            Console.WriteLine("Electricity: {0:f2} lv", TotalElectricity);
            Console.WriteLine("Water: {0:f2} lv", Water);
            Console.WriteLine("Internet: {0:f2} lv", Internet);
            Console.WriteLine("Other: {0:f2} lv", Others);
            Console.WriteLine("Average: {0:f2} lv", Average);
        }
    }
}