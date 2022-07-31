using System;
using System.Globalization;
namespace secao6_vetores_exercicios_propostos_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            double[] precoC = new double[N];
            double[] precoV = new double[N];
            int abaixoDeDez = 0;
            int entreDezEVinte =0;
            int acimaDeVinte =0;
            double valorTotalDeCompra = 0;
            double valorTotalDeVenda = 0;
            double lucroTotal;

            for (int i =0; i<N;i++) {
                string[] dados = Console.ReadLine().Split(' ');
                nomes[i] = dados[0];
                precoC[i] = double.Parse(dados[1],CultureInfo.InvariantCulture);
                precoV[i] = double.Parse(dados[2],CultureInfo.InvariantCulture);
                valorTotalDeCompra += precoC[i];
                valorTotalDeVenda += precoV[i];
            }
            lucroTotal = valorTotalDeVenda - valorTotalDeCompra;

            for (int i =0;i<N;i++) {
                double dezPorcento = precoC[i] / 10.0;
                double vintePorcento = (precoC[i] / 10.0) *2.0;
                if (precoV[i] - precoC[i] < dezPorcento) {
                    abaixoDeDez ++;
                } else if (precoV[i] - precoC[i] >= dezPorcento && precoV[i] - precoC[i] <= vintePorcento) {
                    entreDezEVinte ++;
                } else if (precoV[i] - precoC[i] > vintePorcento) {
                    acimaDeVinte++;
                }
            }
            Console.WriteLine($"Lucro abaixo de 10%: {abaixoDeDez}");
            Console.WriteLine($"Lucro entre 10% e 20%: {entreDezEVinte}");
            Console.WriteLine($"Lucro acima de 20%: {acimaDeVinte}");
            Console.WriteLine($"Valor total de compra: {valorTotalDeCompra.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor total de venda: {valorTotalDeVenda.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Lucro total: {lucroTotal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
