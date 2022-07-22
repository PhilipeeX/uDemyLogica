using System;

namespace BEE1072
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int x = 0;
            int dentro,fora;
            dentro = 0;
            fora = 0;
            
            for (int i = 0; i<N; i++) {
                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    dentro += 1;
                }
                else {
                    fora += 1;
                }
            }
            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");

        }
    }
}
