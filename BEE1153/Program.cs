using System;

namespace BEE1153
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int fatorial = N;

            for (int i = N-1; i>=1; i=i-1) {
                fatorial = fatorial * i;
            }
            Console.WriteLine($"{fatorial}");
        }
    }
}
