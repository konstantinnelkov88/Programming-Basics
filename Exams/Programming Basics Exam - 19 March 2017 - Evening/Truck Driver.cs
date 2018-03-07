using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03TruckDriver
{
    class PProblem03TruckDriver
    {
        static void Main(string[] args)
        {
            //Input
            var season = Console.ReadLine();
            var kmPerMonth = double.Parse(Console.ReadLine());
            double DriverSalary = 0;


            //Calculations
            if (season == "Spring" || season == "Autumn")
            {
                if (kmPerMonth <= 5000)
                {
                    DriverSalary = 0.75 * kmPerMonth * 4 - (0.75 * kmPerMonth * 4) * 0.1;
                }
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                {
                    DriverSalary = 0.95 * kmPerMonth * 4 - (0.95 * kmPerMonth * 4) * 0.1;
                }
                else
                {
                    DriverSalary = 1.45 * kmPerMonth * 4 - (1.45 * kmPerMonth * 4) * 0.1;
                }
            }
            else if (season == "Summer")
            {
                if (kmPerMonth <= 5000)
                {
                    DriverSalary = 0.90 * kmPerMonth * 4 - (0.90 * kmPerMonth * 4) * 0.1;
                }
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                {
                    DriverSalary = 1.10 * kmPerMonth * 4 - (1.10 * kmPerMonth * 4) * 0.1;
                }
                else
                {
                    DriverSalary = 1.45 * kmPerMonth * 4 - (1.45 * kmPerMonth * 4) * 0.1;
                }
            }
            else if (season == "Winter")
            {
                if (kmPerMonth <= 5000)
                {
                    DriverSalary = 1.05 * kmPerMonth * 4 - (1.05 * kmPerMonth * 4) * 0.1;
                }
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                {
                    DriverSalary = 1.25 * kmPerMonth * 4 - (1.25 * kmPerMonth * 4) * 0.1;
                }
                else
                {
                    DriverSalary = 1.45 * kmPerMonth * 4 - (1.45 * kmPerMonth * 4) * 0.1;
                }
            }

            //Output
            Console.WriteLine("{0:f2}", DriverSalary);

        }
    }
}