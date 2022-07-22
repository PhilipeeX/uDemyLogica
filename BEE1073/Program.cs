using System;

namespace BEE1073
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double quadrado = 0;

            for (int i =2; i <= N; i=i+2) {
                quadrado = Math.Pow(i, 2.0);
                Console.WriteLine($"{i}^2 = {quadrado}");
            }
        }
    }
}
