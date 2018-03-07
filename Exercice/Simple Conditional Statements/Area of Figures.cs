using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)

        {
            var fig = Console.ReadLine();
			
             if (fig == "square")
             {
                 var a = double.Parse(Console.ReadLine());
                 Console.WriteLine((a*a).ToString("N3"));

             }
             else  if (fig == "rectangle")
             {
                 var a = double.Parse(Console.ReadLine());
                 var b = double.Parse(Console.ReadLine());
                 Console.WriteLine((a * b).ToString("N3"));

             }
             else if (fig == "circle")
             {
                 var a = double.Parse(Console.ReadLine());
                 Console.WriteLine((Math.PI * a * a).ToString("N3"));
             }
             else if (fig == "triangle")
             {
                 var a = double.Parse(Console.ReadLine());
                 var b = double.Parse(Console.ReadLine());
                 Console.WriteLine((a*b/2).ToString("N3"));
             }
        }
    }
}