using System;

namespace _5_Exerciciosdaescoladeprogramação2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, resultado1;

            Console.WriteLine("Insira o primeiro Valor");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInsira o segundo Valor");
            valor2 = Convert.ToInt32(Console.ReadLine());


            if(valor1 == valor2)
            {
                resultado1 = valor1 + valor2;
                Console.WriteLine("Valores iguais");
            }
            else
            {
                resultado1 = valor1 * valor2;
                Console.WriteLine("Valores diferentes");
            }

            Console.WriteLine("Resultado: " + resultado1);
        }
    }
}
