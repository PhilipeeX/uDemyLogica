using System;
using System.Globalization;
namespace Secao5_estruturas_repetitivas_exercício_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa para ler um número indeterminado de dados, contendo cada um, a idade de um indivíduo.
            // O último dado que não entrará no cálculo, contém um valor de idade negativa.Calcule e imprima a idade
            // média deste grupo de indivíduos. Se for entrado um valor negativo na primeira vez mostre a mensagem
            // "impossível calcular".

            double media;
            double idade = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double x = 0.0;
            double soma = 0.0;

            while (idade > 0)
            {
                x += 1;
                soma = soma + idade;
                idade = double.Parse(Console.ReadLine());
            }
            if (idade < 0)
            {
                Console.WriteLine($"Impossível Calcular");
            }
            else
            {
                media = soma / x;
                Console.WriteLine($"{media.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
