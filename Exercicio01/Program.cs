using System;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valor A: ");
            double valorA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Valor B: ");
            double valorB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Valor C: ");
            double valorC = Convert.ToDouble(Console.ReadLine());

            if (valorA + valorB < valorC)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("A soma de A + B é menor do que C.");
            }
        }
    }
}
