using System;
using System.Globalization;
namespace URI1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B,peso,media;
            peso = 11;
            A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            media = ((A * 3.5) + (B * 7.5)) / peso;

            Console.WriteLine("MEDIA = " + media.ToString("F5",CultureInfo.InvariantCulture));
        }
    }
}
