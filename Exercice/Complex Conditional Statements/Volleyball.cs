using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)

        {
            var year = Console.ReadLine();
            var p = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            if (year == "leap")
            {
                var Saturday_games = (48 - h) * 3 / 4;
                var praznichni_dni = p * 2 / 3;
                var dopalnitelni_igri = 0.15 * (Saturday_games + praznichni_dni + h);
                var obshto_igri = dopalnitelni_igri + (Saturday_games + praznichni_dni + h);
                Console.WriteLine(Math.Floor(obshto_igri));
            }
            else
            {
                var Saturday_games = (48 - h) * 3 / 4;
                var praznichni_dni = p * 2 / 3;
                var obshto_igri = Saturday_games + praznichni_dni + h;
                Console.WriteLine(Math.Floor(obshto_igri));
            }
    


        }
    }
}