using System;

namespace exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            double valor3 = Convert.ToDouble(Console.ReadLine());

            if (valor1 > valor2 && valor1 > valor3 && valor2 > valor3)
            {
                Console.Write($"Valores em ordem decrescente: {valor1}, {valor2}, {valor3}");
            }
            else if (valor1 > valor2 && valor3 > valor2 && valor1 > valor3)
            {
                Console.Write($"Valores em ordem decrescente: {valor1}, {valor3}, {valor2}");
            }
            else if (valor2 > valor1 && valor2 > valor3 && valor1 > valor3)
            {
                Console.Write($"Valores em ordem decrescente: {valor2}, {valor1}, {valor3}");
            }
            else if (valor2 > valor1 && valor2 > valor3 && valor3 > valor1)
            {
                Console.Write($"Valores em ordem decrescente: {valor2}, {valor3}, {valor1}");
            }
            else if (valor3 > valor1 && valor3 > valor2 && valor1 > valor2)
            {
                Console.Write($"Valores em ordem decrescente: {valor3}, {valor1}, {valor2}");
            }
            else if (valor3 > valor1 && valor3 > valor2 && valor2 > valor1)
            {
                Console.Write($"Valores em ordem decrescente: {valor3}, {valor2}, {valor1}");
            }
        }
    }
}
