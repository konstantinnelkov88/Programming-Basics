using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06ControlNumber
{
    class Problem06ControlNumber
    {
        static void Main(string[] args)
        {
           //Input
            var n = byte.Parse(Console.ReadLine());
            var m = byte.Parse(Console.ReadLine());
            var ControlNumber = int.Parse(Console.ReadLine());
            int TotalSum = 0;
            int moves = 0;

            //Calculations
            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    moves++;
                    TotalSum = TotalSum + i * 2 + j * 3;
                    if (TotalSum >= ControlNumber) break;
                }
                if (TotalSum >= ControlNumber) break;
            }

            if (TotalSum < ControlNumber) Console.WriteLine("{0} moves", moves);
            else
            {
                Console.WriteLine("{0} moves", moves);
                Console.WriteLine("Score: {0} >= {1}", TotalSum, ControlNumber);
            }
        }
    }
}