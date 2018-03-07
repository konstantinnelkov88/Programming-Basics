using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)

        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            // figure 1
            if (x > 0 && x < h)
            {
                if (y > 0 && y < h) { Console.WriteLine("inside"); }
                else  if ( y == 0 || y == h) { Console.WriteLine("border"); }
                else { Console.WriteLine("outside"); }
            }
            else if (x == 0) 
            {
                if (y >= 0 && y <= h) { Console.WriteLine("border"); }
                else { Console.WriteLine("outside");}
            }
            else
            {
                // figure 2
                if (x > h && x < 2 * h)
                {
                    if(y > 0 && y < 4*h) { Console.WriteLine("inside");}
                    else if (y == 0 || y == 4*h) {Console.WriteLine("border");}
                    else { Console.WriteLine("outside"); }
                }
                else if (x == h || x == 2 * h)
                {
                    if (y > 0 && y < h) { Console.WriteLine("inside"); }
                    else if (y == 0 || y == h) { Console.WriteLine("border"); }
                    else if (y > h && y <= 4 * h) { Console.WriteLine("border"); }
                    else { Console.WriteLine("outside"); }
                }
                else
                {
                    // figure 3
                    if (x > 2 * h && x < 3 * h)
                    {
                        if (y > 0 && y < h) { Console.WriteLine("inside"); }
                        else if (y == 0 || y == h) { Console.WriteLine("border"); }
                        else { Console.WriteLine("outside"); }
                    }
                    else if (x == 3 * h)
                    {
                        if (y >= 0 && y <= h) { Console.WriteLine("border"); }
                        else { Console.WriteLine("outside"); }
                    }
                    else { Console.WriteLine("outside"); }
                    // end figure 3
                }
                // end figure 2
            }
            // end figure 1

        }
    }
}