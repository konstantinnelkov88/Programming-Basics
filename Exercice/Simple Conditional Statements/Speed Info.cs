using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedInfo
{
    class Program
    {
        static void Main(string[] args)

        {
            var velocity = decimal.Parse(Console.ReadLine());

            if (velocity <= 10)
            {
                Console.WriteLine("slow");
            }
            else if(velocity > 10 && velocity <=50)
            {
                Console.WriteLine("average");
            }
            else if(velocity > 50 && velocity <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (velocity > 150 && velocity <=1000)

            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}