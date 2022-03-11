using System;
using System.Globalization;
namespace URI1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, pi,area;
            pi = 3.14159;
            raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            area = pi * Math.Pow(raio, 2.0);

            Console.WriteLine("A=" + area.ToString("F4",CultureInfo.InvariantCulture));

        }
    }
}
