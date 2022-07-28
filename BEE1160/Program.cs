using System;
using System.Globalization;
namespace BEE1160
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            double pA, pB;
            double g1, g2;
            int anos = 0;

            for (int i = 1; i<=T; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                pA = int.Parse(vet[0]);
                pB = int.Parse(vet[1]);
                g1 = double.Parse(vet[2],CultureInfo.InvariantCulture);
                g2 = double.Parse(vet[3],CultureInfo.InvariantCulture);

                int cre1 = (int)(pA * (g1 / 100));
                int cre2 = (int)(pB * (g2/100));

                for (anos= 0; pA<pB+1;anos++) {

                    pA = pA + cre1;
                    pB = pB + cre2;
                }
                Console.WriteLine($"{anos} anos.");
            }
        }
    }
}
