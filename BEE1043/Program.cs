using System;
using System.Globalization;

namespace BEE1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c,moduloBC,moduloAC,moduloAB,perimetro,area;
            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            moduloBC = Math.Abs(b-c);
            moduloAC = Math.Abs(a-c);
            moduloAB = Math.Abs(a-b);

            if (a < b + c && b < a + c && c < a + b)
            {
                perimetro = a + b + c;
                Console.WriteLine($"Perimetro = {perimetro.ToString("F1",CultureInfo.InvariantCulture)}");
            }
            else 
            {
                area = ((a + b) / 2) * c;
                Console.WriteLine($"Area = {area.ToString("F1",CultureInfo.InvariantCulture)}");
            }
        }
    }
}
