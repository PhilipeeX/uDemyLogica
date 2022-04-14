using System;
using System.Globalization;
namespace BEE1051 {

    class Program {

        static void Main(string[] args){
            
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salario > 2000.00 && salario <= 3000.00)
            {
                salario = (salario - 2000.00) * 0.08;
            }
            else if (salario > 3000.00 && salario <= 4500.00)
            {
                salario = (salario - 3000.00) * 0.18 + 1000 * 0.08;
            }
            else
            {
                salario = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
            }
            
            
            Console.WriteLine($"R$ {salario.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
