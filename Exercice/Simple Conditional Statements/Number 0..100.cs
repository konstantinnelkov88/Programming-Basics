using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number0to100toText
{
    class Program
    {
        static void Main(string[] args)

        {
            var n = int.Parse(Console.ReadLine());
            var first = n / 10;
            var second = n % 10;
            var both = n;

            string firstNum = "";
            string secondNum = "";
            string bothText = "";

            switch (second)

            {
                case 0: secondNum = "zero"; break;
                case 1: secondNum = "one"; break;
                case 2: secondNum = "two"; break;
                case 3: secondNum = "three"; break;
                case 4: secondNum = "four"; break;
                case 5: secondNum = "five"; break;
                case 6: secondNum = "six"; break;
                case 7: secondNum = "seven"; break;
                case 8: secondNum = "eight"; break;
                case 9: secondNum = "nine"; break;

                default: break;
            }

            switch (first)

             {
                case 2: firstNum = "twenty"; break;
                case 3: firstNum = "thirty"; break;
                case 4: firstNum = "fourty"; break;
                case 5: firstNum = "fifty"; break;
                case 6: firstNum = "sixty"; break;
                case 7: firstNum = "seventy"; break;
                case 8: firstNum = "eighty"; break;
                case 9: firstNum = "ninety"; break;
                default: break;
            }

            switch (both)
            {
                case 10: bothText = "ten"; break;
                case 11: bothText = "eleven"; break;
                case 12: bothText = "twelve"; break;
                case 13: bothText = "thirteen"; break;
                case 14: bothText = "fourteen"; break;
                case 15: bothText = "fifteen"; break;
                case 16: bothText = "sixteen"; break;
                case 17: bothText = "seventeen"; break;
                case 18: bothText = "eighteen"; break;
                case 19: bothText = "nineteen"; break;
                default: break;
            }
            if (n >= 0 && n <= 9)
            { Console.WriteLine(secondNum); }
            else if (n >= 10 && n <= 19)
            { Console.WriteLine(bothText); }
            else if (n >= 20 && n <= 100)
            {
                if (n % 10 == 0 && n != 10 && n != 100)
                { Console.WriteLine(firstNum); }
                else if (n == 100)
                { Console.WriteLine("one hundred"); }
                else
                { Console.WriteLine(firstNum + " " + secondNum); }

            }
            else
            { Console.WriteLine("invalid number"); }

        }
    }
}