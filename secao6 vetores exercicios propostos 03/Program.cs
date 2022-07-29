using System;

namespace secao6_vetores_exercicios_propostos_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] A = new int[N];
            int[] B = new int[N];
            int[] C = new int[N];

            string[] ab = Console.ReadLine().Split(' ');
            for (int i =0;i<N;i++) {
                A[i] = int.Parse(ab[i]);
            }
            ab = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                B[i] = int.Parse(ab[i]);
            }
            for (int i =0;i<N;i++) {
                C[i] = A[i] + B[i];
                Console.Write($"{C[i]} ");
            }
            
        }
    }
}
