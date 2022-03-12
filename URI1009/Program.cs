using System;
using System.Globalization;
namespace URI1009
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario,vendas,totalSalario;
            string nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            totalSalario = vendas * 0.15 + salario;
            Console.WriteLine("TOTAL = R$ " + totalSalario.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
