using System;

namespace BEE1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int hInicial, hFinal, mInicial, mFinal, horas, minutos;

            string[] vet = Console.ReadLine().Split(' ');
            hInicial = int.Parse(vet[0]);
            mInicial = int.Parse(vet[1]);
            hFinal = int.Parse(vet[2]);
            mFinal = int.Parse(vet[3]);

            if (hInicial < hFinal && mInicial <= mFinal)
            {
                horas = hFinal - hInicial;
                minutos = mFinal - mInicial;

            }
            else if (hInicial < hFinal && mInicial > mFinal)
            {
                horas = hFinal - hInicial - 1;
                minutos = (60 - mInicial) + mFinal;
            }
            else if (hInicial > hFinal && mInicial <= mFinal)
            {
                horas = (24 - hInicial) + hFinal;
                minutos = mFinal - mInicial;
            }
            else if (hInicial > hFinal && mInicial > mFinal) 
            {
                horas = (24 - hInicial) + hFinal - 1;
                minutos = (60 - mInicial) + mFinal; ;
            }
            else
            {
                horas = 24;
                minutos = 0;
            }

            Console.WriteLine($"O JOGO DUROU {horas} HORAS E {minutos} MINUTOS.");
        }
    }
}
