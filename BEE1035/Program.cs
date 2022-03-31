using System;

namespace BEE1035
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D,X,Y;

            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);
            D = int.Parse(vet[3]);
            X = C + D;
            Y = A + B;

            if (A % 2 == 0 && B > C && D > A && X > Y && C > 0 && D > 0)
            {
                Console.WriteLine($"Valores aceitos");
            }
            else
            {
                Console.WriteLine($"Valores nao aceitos");
            }
        }
    }
}
