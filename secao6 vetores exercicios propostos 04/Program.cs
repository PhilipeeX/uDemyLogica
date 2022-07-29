using System;
using System.Globalization;
namespace secao6_vetores_exercicios_propostos_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler um vetor de N números reais. Em seguida, mostrar na tela a média aritmética de todos 
            // elementos.Depois mostrar todos os elementos do vetor que estejam abaixo da média.

            int N;
            double[] reais;
            string[] reaistring;
            double soma = 0;

            N = int.Parse(Console.ReadLine());
            reais = new double[N];
            reaistring = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                reais[i] = double.Parse(reaistring[i], CultureInfo.InvariantCulture);
                soma = soma + reais[i];
            }
            double media = soma / N;
            Console.WriteLine($"{media.ToString("F3", CultureInfo.InvariantCulture)}");
            for (int i = 0; i < N; i++)
            {
                if (reais[i] < media)
                {
                    Console.WriteLine($"{reais[i].ToString("F1",CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}
