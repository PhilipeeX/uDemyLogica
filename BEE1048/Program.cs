using System;
using System.Globalization;
namespace BEE1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste, salarioFinal, percentual;

            salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            if (salario > 0 && salario <= 400.00)
            {
                percentual = (double)15 / 100;
                reajuste = salario * percentual;
                salarioFinal = salario + reajuste;
                Console.WriteLine($"Novo salario: {salarioFinal.ToString("F2",CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2",CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Em percentual: 15 %");
            }
            else if (salario > 400.00 && salario <= 800.00)
            {
                percentual = (double)12 / 100;
                reajuste = salario * percentual;
                salarioFinal = salario + reajuste;
                Console.WriteLine($"Novo salario: {salarioFinal.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Em percentual: 12 %");
            }
            else if (salario > 800.00 && salario <= 1200.00)
            {
                percentual = (double)10 / 100;
                reajuste = salario * percentual;
                salarioFinal = salario + reajuste;
                Console.WriteLine($"Novo salario: {salarioFinal.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Em percentual: 10 %");
            }
            else if (salario > 1200.00 && salario <= 2000.00)
            {
                percentual = (double)7 / 100;
                reajuste = salario * percentual;
                salarioFinal = salario + reajuste;
                Console.WriteLine($"Novo salario: {salarioFinal.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Em percentual: 7 %");
            }
            else if (salario > 2000.00)
            {
                percentual = (double)4 / 100;
                reajuste = salario * percentual;
                salarioFinal = salario + reajuste;
                Console.WriteLine($"Novo salario: {salarioFinal.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Em percentual: 4 %");
            }
            else
            {
                Console.WriteLine("Valor invalido");
            }
        }
    }
}
