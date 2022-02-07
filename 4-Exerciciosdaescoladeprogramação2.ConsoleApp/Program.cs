using System;

namespace _4_Exerciciosdaescoladeprogramação2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor;

            Console.WriteLine("Insira o valor");
            valor = Convert.ToDouble(Console.ReadLine());

            if (valor % 2 == 0)
            {
                Console.WriteLine("Valor informado é um numero Par");
            }
            else
            {
                Console.WriteLine("Valor informado é um numero Impar");
            }
        }
    }
}
