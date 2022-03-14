using System;
using System.Globalization;
namespace URI1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C,peso,media;
            peso = 10;
            A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            media = (A * 2 + B * 3 + C * 5) / peso;

            Console.WriteLine("MEDIA = " + media.ToString("F1",CultureInfo.InvariantCulture));
        }
    }
}
