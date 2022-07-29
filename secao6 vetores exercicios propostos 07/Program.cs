using System;
using System.Globalization;
namespace secao6_vetores_exercicios_propostos_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler um conjunto de N nomes de alunos, bem como as notas que eles tiraram no 1º e 2º semestres. 
            // Cada uma dessas informações deve ser armazenada em um vetor. Depois, imprimir os nomes dos alunos aprovados,
            // considerando aprovados aqueles cuja média das notas seja maior ou igual a seis.

            int N = int.Parse(Console.ReadLine());
            string[] dados;
            string[] nome = new string[N];
            double[] semestre1 = new double[N];
            double[] semestre2 = new double[N];
            double[] media = new double[N];

            for (int i=0;i<N;i++) {
                dados = Console.ReadLine().Split(' ');
                nome[i] = dados[0];
                semestre1[i] = double.Parse(dados[1],CultureInfo.InvariantCulture);
                semestre2[i] = double.Parse(dados[2],CultureInfo.InvariantCulture);
                media[i] = (semestre1[i] + semestre2[i]) / 2;
            }
            Console.WriteLine("Alunos aprovados:");
            for (int i = 0; i < N ;i++) {
                if (media[i] >= 6) {
                    Console.WriteLine($"{nome[i]}");
                }
            
            }
        }
    }
}
