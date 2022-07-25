using System;

namespace BEE1080
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, ultimoN,posicao,maior;
            ultimoN = 0;
            maior = 0;
            posicao = 0;

            for (int i=1; i<=100;i++) {
                N = int.Parse(Console.ReadLine());
                if (N > ultimoN)
                {
                    maior = N;
                    posicao = i;
                }
                else
                {
                    ultimoN = N;
                }
            }
            Console.WriteLine($"{maior}");
            Console.WriteLine($"{posicao}");
        }
    }
}
