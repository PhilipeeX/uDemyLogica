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
            double media,mediaFinal;
            double idade = double.Parse(Console.ReadLine());
            if (idade < 0)
            {
                Console.WriteLine($"Impossivel calcular");
            }
            else
            {
                while (idade > 0)
                {
                    x += 1;
                    media = idade / x;
                    idade = double.Parse(Console.ReadLine());
                }
            }
        }
    }
}
