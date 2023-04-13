using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lsita1ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            double Fahrenheit;

            Console.WriteLine("Conversor de celsius para Fahrenheit");
            Console.WriteLine();
            Console.WriteLine("Digite o valor em graus Celsius");

            celsius = double.Parse(Console.ReadLine());


            Fahrenheit = (celsius * 9) / (5) + 32;
            Console.WriteLine("temepratura em F° " + Fahrenheit);
        }
    }
}
