using System;
using System.Globalization;
namespace secao7_matrizes_exercicios_propostos_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[,] mat = new double[N, N];
            for (int i = 0; i < N; i++)
            {
                string[] dados = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = double.Parse(dados[j], CultureInfo.InvariantCulture);
                }
            }
            int linha = int.Parse(Console.ReadLine());
            int coluna = int.Parse(Console.ReadLine());

            // a) calcular e imprimir a soma de todos os elementos positivos da matriz.
            double somaDePositivos = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] > 0)
                    {
                        somaDePositivos += mat[i, j];
                    }
                }
            }
            Console.WriteLine($"SOMA DOS POSITIVOS: {somaDePositivos.ToString("F1", CultureInfo.InvariantCulture)}");

            //b) fazer a leitura do índice de uma linha da matriz e, daí, imprimir todos os elementos desta linha.
            Console.Write("LINHA ESCOLHIDA: ");
            for (int i = linha; i == linha; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{mat[i, j].ToString("F1",CultureInfo.InvariantCulture)} ");
                }
            }
            Console.WriteLine();
            //c) fazer a leitura do índice de uma coluna da matriz e, daí, imprimir todos os elementos desta coluna.
            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i =0; i < N; i++)
            {
                for (int j = coluna; j == coluna; j++)
                {
                    Console.Write($"{mat[i, j].ToString("F1", CultureInfo.InvariantCulture)} ");
                }
            }
            Console.WriteLine();
            // d) imprimir os elementos da diagonal principal da matriz.
            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i==j) { Console.Write($"{mat[i, j].ToString("F1", CultureInfo.InvariantCulture)} "); }
                }
            }
            Console.WriteLine();
            // e) alterar a matriz elevando ao quadrado todos os números negativos da mesma. Em seguida imprimir a matriz alterada.
            Console.WriteLine("MATRIZ ALTERADA:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        double alterado = Math.Pow(mat[i, j], 2.0);
                        Console.Write($"{alterado.ToString("F1", CultureInfo.InvariantCulture)} ");
                    }
                    else { Console.Write($"{mat[i,j].ToString("F1",CultureInfo.InvariantCulture)} "); }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
