using System;

namespace BEE1101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menor, maior, soma; ;
            menor = 0;
            maior = 0;
            
            string[] vet = Console.ReadLine().Split(' ');
            int M = int.Parse(vet[0]);
            int N = int.Parse(vet[1]);


            while (M > 0 && N >0) {

                soma = 0;
                if (M > N) {
                    maior = M;
                    menor = N;
                } else if (N>M) {
                    maior = N;
                    menor = M;
                }
                for (int i = menor; i<=maior;i++) {
                    soma = soma + i;
                    Console.Write($"{i} ");
                    if (i==maior) {
                        Console.WriteLine($"Sum={soma}");
                    }
                }


                vet = Console.ReadLine().Split(' ');
                M = int.Parse(vet[0]);
                N = int.Parse(vet[1]);
            }
        }
    }
}
