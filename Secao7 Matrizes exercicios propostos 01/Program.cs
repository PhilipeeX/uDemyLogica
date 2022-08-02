using System;

namespace Secao7_Matrizes_exercicios_propostos_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler dois números M e N, e depois ler uma matriz MxN de números inteiros, conforme exemplo. Em seguida, mostrar
            // na tela somente os números negativos da matriz.

            int M, N;
            string[] estrutura = Console.ReadLine().Split(' ');
            M = int.Parse(estrutura[0]);
            N = int.Parse(estrutura[1]);
            int[,] mat = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine($"VALORES NEGATIVOS:");
            for (int i = 0; i < M; i++)
            {
                for (int j=0;j<N;j++) {
                    if (mat[i,j]<0) {
                        Console.WriteLine($"{mat[i,j]}");
                    }
                }
            }

        }
    }
}
