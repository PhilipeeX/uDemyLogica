using System;

namespace BEE1132
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int maior, menor,soma;
            soma = 0;
            if (x > y)
            {
                maior = x;
                menor = y;
            }
            else if (x < y)
            {
                maior = y;
                menor = x;
            }
            else
            {
                maior = 0;
                menor = 0;
            }

            for (int i = menor; i <= maior; i++)
            {
                if (i % 13 != 0)
                {
                    soma = soma + i;
                }
                else { }
            }
            Console.WriteLine($"{soma}");
        }
    }
}
