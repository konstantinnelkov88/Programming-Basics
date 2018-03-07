using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)

        {
            var suma =  double.Parse(Console.ReadLine());
            var valuta_in = Console.ReadLine();
            var valuta_out = Console.ReadLine();

            switch (valuta_in) 
            {
                case "USD":
                    
                    if (valuta_out == "EUR")

                    {
                        suma = suma * 0.918;

                    }
                        if (valuta_out == "BGN")

                    {
                        suma = suma * 1.79549;
                    }
                           if (valuta_out == "GBP")

                    {
                        suma = suma * 1.4113;
                    }
           
                    break;

                case "BGN":

                    if (valuta_out == "EUR")

                    {
                        suma = suma * 0.5113;
                    }
                        if (valuta_out == "USD")

                    {
                        suma = suma * 0.5569;
                    }
                           if (valuta_out == "GBP")
                    {
                        suma = suma *0.3946;
                    }


                    break;

                case "GBP":

                     if (valuta_out == "EUR")

                    {
                        suma = suma * 1.2956;

                    }
                        if (valuta_out == "USD")

                    {
                        suma = suma * 1.4113;
                    }
                           if (valuta_out == "BGN")

                    {
                        suma = suma * 0.3946;
                    }

                    break;

                case "EUR":

                    if (valuta_out == "GBP")

                    {
                        suma = suma * 0.7718;

                    }
                        if (valuta_out == "USD")

                    {
                        suma = suma * 1.089;
                    }
                           if (valuta_out == "BGN")

                    {
                        suma = suma * 2.53405;
                    }
					
                    break;
            }
            string suma_string = suma.ToString("N2");
            Console.WriteLine(suma_string + " " +valuta_out);
        }
    }
}