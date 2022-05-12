using System;

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
            int x = 0;
            double idade = double.Parse(Console.ReadLine());
            while (idade > 0) {
                x += 1;
                idade = double.Parse(Console.ReadLine());
            }
            double media= (double) idade / x;
            Console.WriteLine($"{media}");
        }
    }
}
