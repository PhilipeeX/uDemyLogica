using System;

namespace BEE1156
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela fórmula:
            // S = 1 + 3 / 2 + 5 / 4 + 7 / 8 + ... +39 /?

            double S = 1;
            double N = 2;
            for (double i = 3; i<=39; i=i+2) {
                S = S + (i/N);
                N = N * 2;
            }
            Console.WriteLine($"{S.ToString("F2")}");
        }
    }
}
