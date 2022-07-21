using System;
using System.Globalization;
namespace BEE1154
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media,soma;
            int y;
            int x = int.Parse(Console.ReadLine());
            media = 0;
            y = 0;
            soma = 0;

            while (x > 0) {
                y += 1;
                soma += x;
                x = int.Parse(Console.ReadLine());
            }
            media = soma / y;
            Console.WriteLine($"{media.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
