using System;
using System.Globalization;
namespace secao6aula7_vetores_exercicio_resolvido_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            string nome;
            int idade,menor,porcentagemMenor;
            double altura,alturaMedia,somaAltura;
            somaAltura = 0;
            menor = 0;
            for (int i =0;i<N;i++) {
                string[] vet = Console.ReadLine().Split(' ');
                nome = vet[0];
                idade = int.Parse(vet[1]);
                altura = double.Parse(vet[2],CultureInfo.InvariantCulture);
                somaAltura += altura;
                if (idade<16) {
                    menor++;
                }
            }
            alturaMedia = somaAltura / N;
            porcentagemMenor = (menor *100) /N;
            Console.WriteLine($"Altura média: {alturaMedia.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Pessoas com menos de 16 anos: {porcentagemMenor.ToString("F1",CultureInfo.InvariantCulture)}%");
        }
    }
}
