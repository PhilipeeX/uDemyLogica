using System;

namespace BEE1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,maior,meio,menor;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            if (a > b && a > c)
            {
                maior = a;
                if (b > c)
                {
                    meio = b;
                    menor = c;
                }
                else
                {
                    meio = c;
                    menor = b;
                }
            }
            else if (b > a && b > c)
            {
                maior = b;
                if (a > c)
                {
                    meio = a;
                    menor = c;
                }
                else
                {
                    meio = c;
                    menor = a;
                }
            }
            else {
                maior = c;
                if (b > a)
                {
                    meio = b;
                    menor = a;
                }
                else {
                    meio = a;
                    menor = b;
                }
            }

            Console.WriteLine($"{menor}");
            Console.WriteLine($"{meio}");
            Console.WriteLine($"{maior}");
            Console.WriteLine($"");
            Console.WriteLine($"{a}");
            Console.WriteLine($"{b}");
            Console.WriteLine($"{c}");


        }
    }
}
