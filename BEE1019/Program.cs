using System;

namespace BEE1019
{
    class Program
    {
        static void Main(string[] args)
        {
            double entradaSegundos, segundos, minutos, horas;
            entradaSegundos = double.Parse(Console.ReadLine());


            horas = entradaSegundos / 3600;
            minutos = (entradaSegundos % 3600)*60;
            segundos = entradaSegundos % 60;
            Console.WriteLine($"Entrada{entradaSegundos}, horas{horas}, minutos{minutos}, segundos{segundos},    ");
        }
    }
}
