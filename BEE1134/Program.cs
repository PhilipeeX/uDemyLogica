using System;

namespace BEE1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int combustivel = int.Parse(Console.ReadLine());
            int Alcool, Gasolina, Diesel;
            Alcool = 0;
            Gasolina = 0;
            Diesel = 0;

            while (combustivel != 4)
            {
                if (combustivel == 1)
                {
                    Alcool += 1;
                }
                else if (combustivel == 2)
                {
                    Gasolina += 1;
                }
                else if (combustivel == 3)
                {
                    Diesel += 1;
                }
                else
                {
                }
                combustivel = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {Alcool}");
            Console.WriteLine($"Gasolina: {Gasolina}");
            Console.WriteLine($"Diesel: {Diesel}");
        }
    }
}
