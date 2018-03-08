using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInRange1to100
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Enter a number in range [1...100]: ");
            var n =  int.Parse(Console.ReadLine());
       
            while(true)
            {
                if (n >= 1 && n <= 100)
                {
                    Console.WriteLine("The number is: " + n);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Number");
                    Console.WriteLine("Enter a number in range [1...100]: ");
                    
                    n = int.Parse(Console.ReadLine());
                }
                
            }

        }
    }
}