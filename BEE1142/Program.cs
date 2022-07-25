using System;

namespace BEE1142
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i<=(N*4);i++) {
                if (i % 4 == 0) {
                    Console.WriteLine("PUM");
                }
                else
                {
                    Console.Write($"{i} ");
                }
            
            }
        }
    }
}
