using System;

namespace BEE1165
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Na matemática, um Número Primo é aquele que pode ser dividido somente por 1 (um) e
            //por ele mesmo. Por exemplo, o número 7 é primo, pois pode ser dividido apenas pelo número 1 e pelo número 7.

            int N = int.Parse(Console.ReadLine());
            int x = 0;
            int valor = 0;
            int j = 0;
            int primo = 0;

            for (int i = 1; i<=N; i++) {
                x = int.Parse(Console.ReadLine());
                for (j= 1; j<=x; j++) {
                    if (x%j ==0) {
                        primo = primo + 1;
                    }
                }
                if (primo == 2)
                {
                    Console.WriteLine($"{x} eh primo");
                }
                else { Console.WriteLine($"{x} nao eh primo"); }
                primo = 0;
            }
        }
    }
}
