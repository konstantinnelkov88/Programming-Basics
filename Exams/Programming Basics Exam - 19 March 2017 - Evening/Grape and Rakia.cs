using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01GrapeandRakia
{
    class Problem01GrapeandRakia
    {
        static void Main(string[] args)
        {
            //Input
            var VineyardSquare = double.Parse(Console.ReadLine());
            var kilosPerSqaureMeter = double.Parse(Console.ReadLine());
            var loss = double.Parse(Console.ReadLine());

            //Calculations
            var grapes = VineyardSquare * kilosPerSqaureMeter - loss;
            var rakia = grapes * 0.45 / 7.5;
            var ProfitRakia = rakia * 9.80;

            var GrapesForSale = 0.55 * grapes;
            var ProfitGrapes = GrapesForSale * 1.5;

            //Output
            Console.WriteLine("{0:f2}",ProfitRakia );
            Console.WriteLine("{0:f2}", ProfitGrapes);
        }
    }
}