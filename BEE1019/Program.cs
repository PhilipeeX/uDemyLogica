using System;

namespace BEE1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int entradaSegundos, segundos, minutos, horas;
            entradaSegundos = int.Parse(Console.ReadLine());


            horas = entradaSegundos / 3600;
            minutos = entradaSegundos / 60 % 60;
            segundos = entradaSegundos % 60;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}
