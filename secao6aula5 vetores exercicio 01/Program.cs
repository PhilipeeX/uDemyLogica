using System;

namespace secao6aula5_vetores_exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia N números inteiros earmazene-os em um vetor. Em seguida mostrar na tela todos 
            // os números negativos lidos.

            int[] vet;
            int N;

            N = int.Parse(Console.ReadLine());
            vet = new int[N];
            string[] s = Console.ReadLine().Split(' ');
            for (int i =0;i<N;i++) {
                vet[i] = int.Parse(s[i]);
            }
            for (int i=0;i<N;i++) {
                if (vet[i]<0) {
                    Console.WriteLine($"{vet[i]}");
                }
            }
        }
    }
}
