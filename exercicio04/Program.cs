using System;

namespace exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} é um número par.");
            }
            else Console.WriteLine($"{x} é um número ímpar.");
        }
    }
}
