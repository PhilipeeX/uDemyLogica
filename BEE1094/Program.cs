using System;

namespace BEE1094
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int casos = int.Parse(Console.ReadLine());
            double porcentagemC, porcentagemR, porcentagemS, C, R, S, cobaias;
            C = 0;
            R = 0;
            S = 0;

            for (int i = 0; i<casos;i++) {
                string[] vet = Console.ReadLine().Split(' ');
                int x = int.Parse(vet[0]);
                char y = char.Parse(vet[1]);
                
                if (y == 'C') {
                    C = C + x;
                } else if (y == 'R') {
                    R = R + x;
                } else if (y == 'S') {
                    S = S + x;
                }
            }
            cobaias = C + R + S;
            porcentagemC = (C/cobaias) * 100;
            porcentagemR = (R / cobaias) * 100;
            porcentagemS = (S / cobaias) * 100;

            Console.WriteLine($"Total: {cobaias} cobaias");
            Console.WriteLine($"Total de coelhos: {C}");
            Console.WriteLine($"Total de ratos: {R}");
            Console.WriteLine($"Total de sapos: {S}");
            Console.WriteLine($"Percentual de coelhos: {porcentagemC.ToString("F2")} %");
            Console.WriteLine($"Percentual de ratos: {porcentagemR.ToString("F2")} %");
            Console.WriteLine($"Percentual de sapos: {porcentagemS.ToString("F2")} %");
        }
    }
}
