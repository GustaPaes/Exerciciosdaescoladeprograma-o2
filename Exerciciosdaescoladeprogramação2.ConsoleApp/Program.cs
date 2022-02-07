using System;

namespace Exerciciosdaescoladeprogramação2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, resultado;
            bool menorque3;

            Console.WriteLine("Insira o valor A");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nInsira o valor B");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nInsira o valor C");
            c = Convert.ToDouble(Console.ReadLine());


            resultado = a + b;
            menorque3 = resultado < c;

            Console.WriteLine("Resultado: " + resultado);

            if (resultado < c)
            {
                Console.WriteLine("Resultado menor que " + c);
            }
            else
            {
                Console.WriteLine("Resultado maior que " + c);
            }
        }
    }
}
