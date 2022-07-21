using System;

namespace BEE1134
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, alcool, gasolina, diesel;
            x = int.Parse(Console.ReadLine());
            alcool = 0;
            gasolina = 0;
            diesel = 0;

            while (x != 4)
            {
                if (x == 1)
                {
                    alcool += 1;
                }
                else if (x == 2)
                {
                    gasolina += 1;
                }
                else if (x == 3)
                {
                    diesel += 1;
                }
                else { }
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}
