using System;

namespace _3_Exerciciosdaescoladeprogramação2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal peso, altura, resultado, resultado1;

            Console.WriteLine("Insira o seu Peso");
            peso = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nInsira a sua Altura");
            altura = Convert.ToDecimal(Console.ReadLine());

            resultado1 = altura * altura;
            resultado = peso / resultado1;

            Console.WriteLine("Resultado: " + resultado);
        }
    }
}
