using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)

        {
            int number = int.Parse(Console.ReadLine());
			
            bool inRange = (number >= 100 && number <= 200 || number == 0);
			
            if (!inRange)
            {
                Console.WriteLine("invalid");
            }

        }
    }
}