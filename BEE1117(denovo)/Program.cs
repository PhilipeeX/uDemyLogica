using System;
using System.Globalization;
namespace BEE1117_denovo_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota, media, X;
            nota = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            X = 0;
            media = 0;
            while (X != 2)
            {
                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    X += 1;
                    media = nota / X;
                }
                nota = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            Console.WriteLine($"media = {media}");
        }
    }
}
