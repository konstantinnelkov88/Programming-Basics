using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)

        {
            var day = int.Parse(Console.ReadLine());
            
            if (day < 1 || day > 7)

            {
                Console.WriteLine("error");
            }
            else
            {
                switch(day)
                {
                    case 1: Console.WriteLine("Monday"); break;
                    case 2: Console.WriteLine("Tuesday"); break;
                    case 3: Console.WriteLine("Wednesday"); break;
                    case 4: Console.WriteLine("Thursday"); break;
                    case 5: Console.WriteLine("Friday"); break;
                    case 6: Console.WriteLine("Saturday"); break;
                    case 7: Console.WriteLine("Sunday"); break;
                }
            }

        }
    }
}