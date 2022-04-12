using System;

namespace BEE1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal1 = Console.ReadLine();
            string animal2 = Console.ReadLine();
            string animal3 = Console.ReadLine();

            if (animal1 == "vertebrado")
            {
                if (animal2 == "ave")
                {
                    if (animal3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (animal3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (animal2 == "mamifero")
                {
                    if (animal3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (animal3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if (animal1 == "invertebrado")
            {
                if (animal2 == "inseto")
                {
                    if (animal3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (animal3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (animal2 == "anelideo")
                {
                    if (animal3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (animal3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
            else
            {
                Console.WriteLine("dados incorretos");
            }
        }
    }
}
