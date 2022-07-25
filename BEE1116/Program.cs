using System;

namespace BEE1116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i=1;i<=N;i++) {

                string[] vet = Console.ReadLine().Split(' ');
                double x = int.Parse(vet[0]);
                double y = int.Parse(vet[1]);

                if (y == 0)
                {
                    Console.WriteLine($"divisao impossivel");
                }
                else {
                    double divisao = x / y;
                    Console.WriteLine($"{divisao.ToString("F1")}");
                }

            }
        }
    }
}
