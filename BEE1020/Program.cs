using System;

namespace BEE1020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N,anos,dias,meses;
            N = int.Parse(Console.ReadLine());

            anos = N / 365;
            meses = N % 365 / 30;
            dias = N % 365 % 30;


            Console.WriteLine($"{anos} ano(s)");
            Console.WriteLine($"{meses} mes(es)");
            Console.WriteLine($"{dias} dia(s)");
        }
    }
}
