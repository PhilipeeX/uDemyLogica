using System;
using System.Globalization;
namespace BEE1079
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            float x, y, z,media;
            
            for (int i=0; i<N;i++) {
                string[] vet = Console.ReadLine().Split(' ');
                x = float.Parse(vet[0], CultureInfo.InvariantCulture);
                y = float.Parse(vet[1], CultureInfo.InvariantCulture);
                z = float.Parse(vet[2], CultureInfo.InvariantCulture);

                x = x * 2f;
                y = y * 3f;
                z = z * 5f;
                media = (x + y + z) / 10;
                Console.WriteLine($"{media.ToString("F1",CultureInfo.InvariantCulture)}");
            }

        }
    }
}
