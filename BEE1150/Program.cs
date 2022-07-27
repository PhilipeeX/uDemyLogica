using System;

namespace BEE1150
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());
            while (Z <= X)
            {
                Z = int.Parse(Console.ReadLine());
            }
            int soma = X;
            int i = 0;

            for (i = 1; soma <= Z; i++)
            {
                soma = soma + (X + i);
            }
            Console.WriteLine($"{i}");
        }

    }
}

