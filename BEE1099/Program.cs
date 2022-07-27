using System;

namespace BEE1099
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int maior, menor,soma;
            menor = 0;
            maior = 0;
            soma = 0;

            for (int i = 1; i <= N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int x = int.Parse(vet[0]);
                int y = int.Parse(vet[1]);

                if (x > y)
                {
                    maior = x;
                    menor = y;
                }
                else if (y > x)
                {
                    maior = y;
                    menor = x;
                }
                for (int I = menor+1; I<maior; I++) {
                    if (I % 2 != 0) {
                        soma += I;
                    }
                }
                Console.WriteLine($"{soma}");
                soma = 0;
                maior = 0;
                menor = 0;
            }
        }
    }
}
