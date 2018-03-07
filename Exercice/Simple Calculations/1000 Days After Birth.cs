using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)

        {
            var date1Str = Console.ReadLine();
            DateTime date1 = DateTime.ParseExact(date1Str, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime date2 = date1.AddDays(999);
            string date2Str = date2.ToString("dd-MM-yyyy");
            Console.WriteLine(date2Str);

        }

    }
}