using System;

namespace secao7_matrizes_exercicios_propostos_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] mat = new int[N, N];

            for (int i =0;i<N;i++) {
                string[] dados = Console.ReadLine().Split(' ');
                for (int j =0; j< N; j++) {
                    mat[i, j] =int.Parse(dados[j]);
                }
            }
            int[] maior = new int[N];
            int mais = 0;
            for (int i =0; i<N; i++) {
                for (int j =0; j<N; j++) {
                    if (mat[i,j]>maior[i]) {
                        maior[i] = mat[i,j];
                    }
                }
                mais++;
            }
            for (int i =0; i<N; i++) {
                Console.WriteLine($"{maior[i]}");
            }
        }
    }
}
