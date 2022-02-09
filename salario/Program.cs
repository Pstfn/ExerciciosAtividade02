using System;

namespace salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite seu salário: \n");
            double salario = Convert.ToDouble(Console.ReadLine());
            double salarioAumento = salario + (salario * 0.15);
            double salarioDesconto = salarioAumento - (salario * 0.08);
            Console.WriteLine("seu salario inicial é " + salario + " reais.");
            Console.WriteLine("seu salario com aumento de é " + salarioAumento + " reais.");
            Console.WriteLine("seu salario com desconto é " + salarioDesconto + " reais.");


        }
    }
}
