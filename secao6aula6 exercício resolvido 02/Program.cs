using System;
using System.Globalization;
namespace secao6aula6_exercício_resolvido_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia N números reais e armazene-os em um vetor.Em seguida:
            // - imprimir todos os elementos do vetor
            // - Mostrar na tela a soma e a média dos elementos do vetor.

            int N;
            double[] vet;
            double soma = 0;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];
            string[] vet2 = Console.ReadLine().Split(' ');
            for (int i =0;i<N;i++) {
                vet[i] = double.Parse(vet2[i],CultureInfo.InvariantCulture);
                soma = soma + vet[i];
            }
            for (int i =0;i<N;i++) {
                Console.Write($"{vet[i].ToString("F1",CultureInfo.InvariantCulture)} ");
                if (i==N-1) {
                    Console.WriteLine($"{vet[i].ToString("F1", CultureInfo.InvariantCulture)} ");
                }
            }
            double media = soma / N;
            Console.WriteLine($"{soma.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
