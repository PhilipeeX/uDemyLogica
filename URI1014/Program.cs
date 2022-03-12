using System;
using System.Globalization;
namespace URI1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y,mediaKm;
            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            mediaKm = X / Y;

            Console.WriteLine(mediaKm.ToString("F3",CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
