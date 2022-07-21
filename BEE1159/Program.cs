using System;
using System.Globalization;
namespace BEE1159
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soma de Pares Consecutivos

            double soma, x,y;
            x = int.Parse(Console.ReadLine());
            soma = 0;

            while (x != 0)
            {
                if (x % 2 == 0)
                {
                    soma = x + (x+2) + (x+4) + (x+6) + (x+8);
                }
                else
                {
                    y = x + 1;
                    soma = y + (y + 2) + (y + 4) + (y + 6) + (y + 8);
                }
                x = int.Parse(Console.ReadLine());
                Console.WriteLine($"{soma}");
            }
        }
    }
}
