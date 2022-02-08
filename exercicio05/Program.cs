using System;

namespace exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor A: ");
            double valorA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor B: ");
            double valorB = Convert.ToDouble(Console.ReadLine());

            double valorC;

            if (valorA == valorB)
            {
                valorC = valorA + valorB;
            }
            else
            {
                valorC = valorA * valorB;
            }
            Console.WriteLine($"O resultado do valor C é: {valorC}");
        }
    }
}
