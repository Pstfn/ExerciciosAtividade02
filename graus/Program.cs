using System;

namespace graus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em graus celcius: \n");
            double celcius = Convert.ToDouble(Console.ReadLine());
            double calculo = (celcius * 1.8) + 32;
            Console.WriteLine("A temperatura em fahrenheit é de: \n" + calculo + " graus.");
        }
    }
}
