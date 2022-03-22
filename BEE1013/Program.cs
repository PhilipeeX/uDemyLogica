using System;

namespace BEE1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C,maior1,maiorzao;
            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            maior1 = (A + B + Math.Abs(A-B))/ 2; //fórmula pra saber qual valor é maior entre 2 números
            maiorzao = (maior1 + C + Math.Abs(maior1 - C)) / 2;
            
            Console.WriteLine($"{maiorzao} eh o maior");

        }
    }
}
