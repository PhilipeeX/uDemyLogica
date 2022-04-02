using System;
using System.Globalization;
namespace BEE1037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double entrada;

            entrada = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (entrada >= 0 && entrada <= 25.0) // INTERVALO [0,25]
            { Console.WriteLine("Intervalo [0,25]"); }
            else if (entrada > 25.00 && entrada <= 50.00) //INTERVALO (25,50]
            { Console.WriteLine("Intervalo (25,50]"); }
            else if (entrada > 50.00 && entrada <= 75.00) //INTERVALO  (50,75]
            { Console.WriteLine("Intervalo (50,75]"); }
            else if (entrada > 75.00 && entrada <= 100.00) //INTERVALO  (75,100]
            { Console.WriteLine("Intervalo (75,100]"); }
            else { Console.WriteLine($"Fora de intervalo"); }
        }
    }
}
