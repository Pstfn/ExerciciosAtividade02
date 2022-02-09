using System;

namespace NomeIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("qual sua idade? (em anos)");
            double idade = Convert.ToDouble(Console.ReadLine());
            double diasDeVida = idade * 365;
            Console.WriteLine("" + nome + " você já viveu " + diasDeVida + " dias.");
        }
    }
}
