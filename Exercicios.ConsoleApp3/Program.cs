using System;

namespace Exercicios.ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a valor da base em metros quadrados: \n");
            double basemetros = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite a valor da altura em metros quadrados: \n");
            double alturametros = Convert.ToDouble(Console.ReadLine());

            double calculoBxH = basemetros * alturametros;
            Console.WriteLine("A área do seu terreno é de: \n" + calculoBxH + " metros quadrados.");
        }
    }
}
