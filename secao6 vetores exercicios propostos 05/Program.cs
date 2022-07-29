using System;
using System.Globalization;
namespace secao6_vetores_exercicios_propostos_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N,soma,pares;
            int[] numeros;
            string[] numerostrings;
            double media;
            N = int.Parse(Console.ReadLine());
            numeros = new int[N];
            numerostrings = Console.ReadLine().Split(' ');
            soma = 0;
            pares = 0;
            for (int i =0;i<N;i++) {
                numeros[i] = int.Parse(numerostrings[i]);
                if (numeros[i] % 2 == 0) {
                    soma += numeros[i];
                    pares++;
                }
            }media = soma / pares;
            Console.WriteLine($"{media.ToString("F1",CultureInfo.InvariantCulture)}");

        }
    }
}
