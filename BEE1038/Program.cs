using System;
using System.Globalization;
namespace BEE1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double preco;

            string[] vet = Console.ReadLine().Split(' ');

            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            if (codigo == 1)//cachorro quente
            {
                preco = quantidade * 4.00;
                Console.WriteLine($"Total: R$ {preco.ToString("F2", CultureInfo.InvariantCulture)}");

            }
            else if (codigo == 2)//X-salada
            {
                preco = quantidade * 4.50;
                Console.WriteLine($"Total: R$ {preco.ToString("F2", CultureInfo.InvariantCulture)}");

            }
            else if (codigo == 3)//X-Bacon
            {
                preco = quantidade * 5.00;
                Console.WriteLine($"Total: R$ {preco.ToString("F2", CultureInfo.InvariantCulture)}");

            }
            else if (codigo == 4)//Torrada simples
            {
                preco = quantidade * 2.00;
                Console.WriteLine($"Total: R$ {preco.ToString("F2", CultureInfo.InvariantCulture)}");

            }
            else if (codigo == 5)//Refrigerante
            {
                preco = quantidade * 1.50;
                Console.WriteLine($"Total: R$ {preco.ToString("F2", CultureInfo.InvariantCulture)}");

            }
            else
            {
                Console.WriteLine($"Valor inválido");
            }
        }
    }
}
