using System;
using System.Globalization;
namespace URI1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo1, pecas1, codigo2, pecas2;
            double valor1,valor2,valorTotal;
            
            string[] vet1 = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(vet1[0]);
            pecas1 = int.Parse(vet1[1]);
            valor1 = double.Parse(vet1[2],CultureInfo.InvariantCulture);
            
            string[] vet2 = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(vet2[0]);
            pecas2 = int.Parse(vet2[1]);
            valor2 = double.Parse(vet2[2],CultureInfo.InvariantCulture);

            valorTotal = (pecas1 * valor1) + (pecas2 * valor2);
            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
