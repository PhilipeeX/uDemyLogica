using System;

namespace BEE1143
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i<=N; i++) {
                double qua = (double)Math.Pow(i, 2.0);
                double cub = (double)Math.Pow(i, 3.0);

                Console.WriteLine($"{i} {qua} {cub}");
            }
        }
    }
}
