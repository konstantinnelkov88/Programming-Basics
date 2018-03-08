using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)

        {
            var n = int.Parse(Console.ReadLine());
            int rows = 0;
              if (n % 2 == 0) { rows = n - 1; }
              else { rows = n; }

                if (n == 1) { Console.WriteLine("*"); }

                else if (n == 2) { Console.WriteLine("**"); }

              else
            {               
                for (int i = 1; i <= rows; i++)
                {
                    int mid = 0;
                    int leftRight = 0;
                    if (i <= rows / 2) 
                    { 
                        leftRight = (n - 1) / 2 - (i - 1);
                        mid = n - 2 * leftRight - 2;
                    }
                    else {
                        if (n % 2 == 0) { leftRight = rows / 2 - (n - i) + 1; }
                        else { leftRight = rows / 2 - (n - i); }
                        mid = n - 2 * leftRight - 2;
                    }
                  
                    for (int j = 1; j <= leftRight; j++)
                    {
                        Console.Write("-");
                    }

                    if (mid >= 0)
                    {
                        Console.Write("*");
                        Console.Write(new string('-', mid));
                    }
                    Console.Write("*");

                    for (int j = 1; j <= leftRight; j++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}