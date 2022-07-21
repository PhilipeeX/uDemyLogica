using System;

namespace BEE1131
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, grenais, empates, novo, inter, gremio;

            string[] vet; 
            novo = 1;
            grenais = 0;
            inter = 0;
            gremio = 0;
            empates = 0;

            while (novo == 1)
            {
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
                grenais += 1;
                if (x > y)
                {
                    inter += 1;
                }
                else if (x < y)
                {
                    gremio += 1;
                }
                else
                {
                    empates += 1;
                }
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{grenais} grenais");
            Console.WriteLine($"Inter: {inter}");
            Console.WriteLine($"Gremio: {gremio}");
            Console.WriteLine($"Empates: {empates}");
            if (gremio > inter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else if (inter > gremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else {
                Console.WriteLine("Não houve vencedor");
            }
        }
    }
}
