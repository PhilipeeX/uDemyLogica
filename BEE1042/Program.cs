using System;

namespace BEE1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,maiorAB,maiorBC,maior,meio,menor;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);
            maiorAB = (a + b + Math.Abs(a - b)) / 2;
            maiorBC = (b + c + Math.Abs(b - c))/2;

            if (a >= maiorBC)
            {
                maior = a;
                meio = maiorBC;
            }
            else if (c >= maiorAB)
            {
                maior = c;
                meio = maiorAB;
            }
            else { Console.WriteLine("seila"); }

            Console.WriteLine($"{maior} {meio}");
            
        }
    }
}
