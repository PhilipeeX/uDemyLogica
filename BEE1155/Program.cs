using System;

namespace BEE1155
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double S = 1;
            for (double i = 2.0; i <= 100; i++)
            {
                S = S + (1.0/i);
            }
            Console.WriteLine($"{S.ToString("F2")}");
        }
    }
}
