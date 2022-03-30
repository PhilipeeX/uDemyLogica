using System;
using System.Globalization;
namespace Secao4_sintaxe_opcional_usd_oper_de_atribuicao_cumulativa
{
    class Program
    {
        static void Main(string[] args)
        {
            /*PROBLEMA EXEMPLO: Uma operadora de telefonia cobra R$ 50,00 por um plano básico que dá direito a 100 minutos de telefone.
             Cada minuto que exceder a franquia de 100 minutos custa R$ 2,00. Faça um programa para ler a quantidade de minutos que uma pessoa
            consumiu, e entao mostrar o valor a ser pago.*/

            int minutos;
            double conta;
            minutos = int.Parse(Console.ReadLine());
            conta = 50.00;
            if (minutos <= 100)
            {
                Console.WriteLine($"Valor a ser pago: R$ {conta.ToString("F2",CultureInfo.InvariantCulture)}");
            }
            else {
                conta = conta + (minutos - 100) * 2; //OBS: onde é lido: "conta = conta + (...)". Pode ser substituído por "conta += (...)"
                Console.WriteLine($"Valor a ser pago: R${conta.ToString("F2",CultureInfo.InvariantCulture)}");
            }
        }
    }
}
