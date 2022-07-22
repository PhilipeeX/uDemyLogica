using System;

namespace BEE1074
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int valor;

            for (int i = 0; i < N; i++) {
                valor = int.Parse(Console.ReadLine());
                if (valor == 0) {
                    Console.WriteLine("NULL");
                } else if (valor % 2 == 0) {
                    Console.Write($"EVEN ");
                } else {
                    Console.Write($"ODD ");
                }
                if (valor > 0)
                {
                    Console.WriteLine("POSITIVE");
                }
                else if (valor < 0)
                {
                    Console.WriteLine("NEGATIVE");
                }
                else { }
                }
            }
        }
    }
