using System;

namespace secao6_vetores_exercicios_propostos_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()) ;
            string[] pessoas = new string[N];
            string[] nomes = new string[N];
            int[] idades = new int[N];
            
            for (int i =0; i<N; i++) {
                pessoas = Console.ReadLine().Split(' ');
                nomes[i] = pessoas[0];
                idades[i] = int.Parse(pessoas[1]);
            }
            int velho = idades[0];
            string nome = "ninguem";
            for (int i =1;i<N;i++) {
                if (idades[i]> velho) {
                    velho = idades[i];
                    nome = nomes[i];
                }
            }

            Console.WriteLine($"Pessoa mais velha: {nome}");
        }
    }
}
