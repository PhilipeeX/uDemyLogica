using System;

namespace BEE1145
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escreva um programa que leia dois valores X e Y.
            // A seguir, mostre uma sequência de 1 até Y, passando
            // para a próxima linha a cada X números.

            string[] vet = Console.ReadLine().Split(' ');
            int X = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            for (int i = 1; i <= y; i++)
            {
                if (i % X == 0)
                {
                    Console.WriteLine($"{i}");
                }
                else if (i == y)
                {
                    Console.Write($"{i}");
                }
                else
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
