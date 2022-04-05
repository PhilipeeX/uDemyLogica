using System;
using System.Globalization;
namespace BEE1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y, Z;

            string[] vet = Console.ReadLine().Split(' ');

            X = double.Parse(vet[0], CultureInfo.InvariantCulture);
            Y = double.Parse(vet[1], CultureInfo.InvariantCulture);
            Z = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double a, b, c;
            if (X >= Y && X >= Z) //"X" é o maior
            {
                a = X * 1;
                if (Y >= Z) // "Y" é o medio e "Z" o menor
                {
                    b = Y;
                    c = Z;
                }
                else // "Z" é o medio e "Y" o menor
                {
                    b = Z;
                    c = Y;
                }
            }
            else if (Y >= X && Y >= Z) //"Y" é o maior
            {
                a = Y;
                if (X >= Z) // "X" é o medio e "Z" o menor
                {
                    b = X;
                    c = Z;
                }
                else // "Z" é o medio e "X" o menor
                {
                    b = Z;
                    c = X;
                }
            }
            else if (Z >= X && Z >= Y) //"Z" é o maior
            {
                a = Z;
                if (X >= Y) // "X" é o medio e "Y" o menor
                {
                    b = X;
                    c = Y;
                }
                else // "Y" é o medio e "X" o menor
                {
                    b = Y;
                    c = X;
                }
            }
            
            Console.WriteLine($"MAIOR: {a} médio: {b} e menor: {c}");
            Console.ReadLine();
        }
    }
}
