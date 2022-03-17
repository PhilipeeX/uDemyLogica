using System;
using System.Globalization;
namespace BEE1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C,areaTri,pi,areaCir,areaTrap,areaQua,areaRet;
            pi = 3.14159;

            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0],CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);
            
            areaTri = (A*C) / 2;
            areaCir = pi * Math.Pow(C,2.0);
            areaTrap = (A + B) / 2 * C;
            areaQua = Math.Pow(B,2.0);
            areaRet = A * B;

            Console.WriteLine($"TRIANGULO: {areaTri.ToString("F3",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {areaCir.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {areaTrap.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {areaQua.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {areaRet.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}
