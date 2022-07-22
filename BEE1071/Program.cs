using System;

namespace BEE1071
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = ;
            int soma = 0;

            for (int i = 1; z < ((x+y+Math.Abs(x-y))/2); i++) {
                z = x + i;
                if (z % 2 == 0)
                {
                    z = z + 1;
                }
                else {
                    soma = soma + z;
                }
            }

        }
    }
}
