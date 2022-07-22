using System;

namespace BEE1078
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int result;

            for (int i = 1; i <= 10 ; i++ ) {
                result = N * i;
                Console.WriteLine($"{i} x {N} = {result}");
            }
        }
    }
}
