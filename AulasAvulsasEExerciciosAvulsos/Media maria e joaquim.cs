using System;
using System.Globalization;
namespace primeira_aulaUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade1, idade2;
            double media;

            string[] vet = Console.ReadLine().Split(' ');
            string nome1 = vet[0];
            idade1 = int.Parse(vet[1]);

            string[] vet2 = Console.ReadLine().Split(' ');
            string nome2 = vet2[0];
            idade2 = int.Parse(vet2[1]);

            media = (double)(idade1 + idade2) / 2;

            Console.WriteLine("a idade média de " + nome1 + " e " + nome2 + " é de " + media + " anos");

        }
    }
}
