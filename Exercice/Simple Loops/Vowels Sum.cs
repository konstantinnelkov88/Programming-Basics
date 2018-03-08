using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            double sum = 0;

            for (int i = 1; i < s.Length ; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                    switch (s[i])
                    {
                        case 'a': sum += 1;break;
                        case 'e': sum += 2;break;
                        case 'i': sum += 3;break;
                        case 'o': sum += 4;break;
                        case 'u': sum += 5;break;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}