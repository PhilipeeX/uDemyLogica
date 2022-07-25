using System;

namespace BEE1133
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int maior, menor;
            maior = x;
            menor = y;

            if (x<y) {
                maior = y;
                menor = x;
            }

            for (int i = menor+1; i<maior; i++) {
                if (i % 5 == 2 || i % 5 ==3) {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}
