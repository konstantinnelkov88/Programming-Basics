using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)

        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            int mins = 0;

            int secs = a + b + c;

            if (secs >= 60)
            {
                secs = secs - 60;
                mins++;

                if (secs > 60)
                {
                    secs = secs - 60;

                    mins++;

                    if(secs < 10) 

                    {
                       Console.WriteLine(mins+":0"+secs);
                    }
                    else 
                    {
                       Console.WriteLine(mins+":"+secs);
                    }
                  
                }

                else if (secs < 10)
                {
                    Console.WriteLine(mins+":0"+secs);
                }

                else
                {
                    Console.WriteLine(mins+":"+secs);
                }
            }
            else if (secs < 10)
            {
                Console.WriteLine(mins+":0"+secs);
            }
            else
            {
                Console.WriteLine(mins+":"+secs);
            }
        }
    }
}