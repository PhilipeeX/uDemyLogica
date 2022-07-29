using System;
using System.Globalization;
namespace secao6_vetores_exercicios_propostos_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[] vet;
            string[] db = Console.ReadLine().Split(' ');
            vet = new double[N];
            double maior = 0;
            int posicao = 0;

            for (int i =0;i<N;i++) {
                vet[i] = double.Parse(db[i], CultureInfo.InvariantCulture);
                if (vet[i] > maior) {
                    maior = vet[i];
                    posicao = i;
                }
            }
            Console.WriteLine($"{maior.ToString("F1",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{posicao}");

        }
    }
}
