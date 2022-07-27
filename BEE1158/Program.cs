using System;

namespace BEE1158
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int X = int.Parse(vet[0]);
                int Y = int.Parse(vet[1]);
                int K = 0;
                int soma = 0;
                for (int I = X; K < Y; I++)
                {
                    
                    if (I % 2 !=0) {
                        K = K + 1;
                        soma = soma + I;
                    }
                }
                Console.WriteLine($"{soma}");
                
                
            }

        }
    }
}
