using System;

namespace BEE1071
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int min, max;

            if (x >y) {
                min = y;
                max = x;
            } 
            else {
                min = x;
                max = y;
            }
            int soma = 0;
            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
                else { }
            }
            Console.WriteLine($"{soma}");
        }
    }
}
