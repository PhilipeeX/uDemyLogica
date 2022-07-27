using System;

namespace BEE1149
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo para ler um valor A e um valor N.
            // Imprimir a soma de A + i para cada i com os valores (0 <= i <= N-1).
            // Enquanto N for negativo ou ZERO, um novo N(apenas N) deve ser lido.

            string[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0]);
            int N = int.Parse(vet[1]);
            int soma = 0;

            while (N<=0) {
                vet = Console.ReadLine().Split(' ');
                N = int.Parse(vet[0]);
            }

            for (int i = 0; i >=0 && i <= (N-1); i++) {
                soma = soma + A+i;
            }
            Console.WriteLine($"{soma}");
        }
    }
}
