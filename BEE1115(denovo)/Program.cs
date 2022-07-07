using System;

namespace BEE1115_denovo_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int X = int.Parse(vet[0]);
            int Y = int.Parse(vet[1]);

            while (X != 0 && Y != 0) {
                if (X > 0)
                {
                    if (Y > 0) { Console.WriteLine("primeiro"); }
                    else { Console.WriteLine("quarto"); }
                }
                else {
                    if (Y > 0) { Console.WriteLine("segundo"); }
                    else { Console.WriteLine("terceiro"); } }
                vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);
            }
        }
    }
}
