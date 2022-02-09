using System;

namespace PadariaHotpão
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos pães foram vendidos hoje?");
            double paesVendidos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantas broas foram vendidas hoje?");
            double broasVnedidas = Convert.ToDouble(Console.ReadLine());
            double valorFinalPaes = paesVendidos * 0.12;
            double valorFinalBroas = broasVnedidas * 1.50;
            double faturamento = valorFinalPaes + valorFinalBroas;
            Console.WriteLine("O valor arrecadado hoje foi " + faturamento + " reais.");
            double valorPorcentagem = faturamento * 0.1;
            Console.WriteLine("O valor a ser guardado na poupança é " + valorPorcentagem + " reais.");
        }
    }
}
