using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)

        {
            var usd =  double.Parse(Console.ReadLine());
            var bgn = usd * 1.79549;
            string bgn_string = bgn.ToString("N2");
            Console.WriteLine(bgn_string + " BGN");

        }
    }
}