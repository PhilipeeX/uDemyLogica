using System;

namespace Revendo_URI1113
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string[] xy = Console.ReadLine().Split(' ');
            x = int.Parse(xy[0]);
            y = int.Parse(xy[1]);

            while (x != y) {
                if (x > y)
                {
                    Console.WriteLine("Decrescente");
                }
                else {
                    Console.WriteLine("Crescente");
                }
                xy = Console.ReadLine().Split(' ');
                x = int.Parse(xy[0]);
                y = int.Parse(xy[1]);
            }
        }
    }
}
