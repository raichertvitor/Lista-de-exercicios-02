using System;

namespace exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"Seu IMC é: {imc}");

            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso!");
            }
            else if (imc > 18.5 && imc <= 25)
            {
                Console.WriteLine("Você está no peso normal.");
            }
            else if (imc > 25 && imc <= 30)
            {
                Console.WriteLine("Você está acima do peso!");
            }
            else if (imc > 30)
            {
                Console.WriteLine("Você está obeso!!!");
            }
        }
    }
}
