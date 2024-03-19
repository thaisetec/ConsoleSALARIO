using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSALARIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a forma de contratação? \nA- assalariado\nC- comissionado\nH-horista");
                string contrat = Console.ReadLine().ToUpper();
            double salario
            switch (contrat)
            {
                case "A":
                    Console.WriteLine("digite o salário bruto");
                   double salario = double.Parse(Console.ReadLine());
                    Console.WriteLine("informe o valor do desconto");
                    double desc = double.Parse(Console.ReadLine());
                    result = salario - desco;
                    break;

            }

        }
    }
}
