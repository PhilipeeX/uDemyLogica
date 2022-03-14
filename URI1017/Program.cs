using System;
using System.Globalization;
namespace URI1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempoTotal, veloc, kmTotal;
            double litros;

            tempoTotal = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            veloc = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            kmTotal = tempoTotal * veloc;

            litros = (double)kmTotal / 12;

            Console.WriteLine(litros.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
