using System;
using System.Globalization;
namespace URI1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int nFuncionario, horas;
            double pHora, totalHora;
            
            nFuncionario = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            pHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            totalHora = (double)pHora * horas;

            Console.WriteLine("NUMBER = " + nFuncionario);
            Console.WriteLine("SALARY = U$ " + totalHora.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
