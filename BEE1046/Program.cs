using System;

namespace BEE1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, total;

            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);

            if (A < B)
            {
                total = B - A;
                Console.WriteLine($"O JOGO DUROU {total} HORA(S)");
            }
            else if (A > B) {
                total = (24 - A) + B;
                Console.WriteLine($"O JOGO DUROU {total} HORA(S)");
            }
            else { 
                Console.WriteLine($"O JOGO DUROU 24 HORA(S)"); }
        }
    }
}
