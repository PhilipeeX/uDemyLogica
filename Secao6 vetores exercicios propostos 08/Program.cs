using System;
using System.Globalization;
namespace Secao6_vetores_exercicios_propostos_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tem-se um conjunto de dados contendo a altura e o sexo (M, F) de N pessoas. Fazer um programa que calcule e escreva:
            //- a maior e a menor altura do grupo
            //- a média de altura das mulheres
            //- o número de homens

            int N = int.Parse(Console.ReadLine());
            double[] altura = new double[N];
            char[] sexo = new char[N];

            for (int i =0; i<N;i++) {
                string[] dados = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(dados[0],CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(dados[1]);
            }
            //maior e menor altura
            double maiorA = altura[0];
            double menorA = altura[0];
            for (int i = 1; i<N;i++) {
                if (altura[i]>maiorA) {
                    maiorA = altura[i];
                } else if (altura[i]<menorA) {
                    menorA = altura[i];
                }
            }
            // media da altura das mulheres e total homens
            double somaAlturasM = 0;
            int totalMulheres = 0;
            int totalHomens = 0;
            for (int i =0;i<N;i++) {
                if (sexo[i] == 'F')
                {
                    somaAlturasM += altura[i];
                    totalMulheres += 1;
                }
                else { totalHomens += 1; }
            }
            double mediaAlturaMulheres = somaAlturasM / totalMulheres;

            Console.WriteLine($"Menor altura = {menorA.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Maior altura = {maiorA.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Media das alturas das mulheres = {mediaAlturaMulheres.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Numero de homens = {totalHomens}");

        }
    }
}
