using System;

namespace secao6_vetores_exercicios_propostos_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numeros = new int[N];
            string[] a = Console.ReadLine().Split(' ');
            for (int i =0;i<N;i++) {
                numeros[i] = int.Parse(a[i]);
            }
            int par = 0;
            for (int i =0;i<N;i++) {
                if (numeros[i] %2 ==0) {
                    par = par + 1;
                    Console.Write($"{numeros[i]} ");
                }
                
            }
            Console.WriteLine("");
            Console.WriteLine($"{par}");
        }
    }
}
