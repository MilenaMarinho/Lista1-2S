using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reais conversao1;
            conversao1 = new Reais();

            Console.WriteLine("\n---------Exercício 7 da Lista 1---------\n");

            Console.Write("Insira o Valor da Cotação do Dólar: R$");
            conversao1.setCot(double.Parse(Console.ReadLine()));

            Console.Write("Insira um  um Valor em Dólares: US$");
            conversao1.setDol(double.Parse(Console.ReadLine()));

            conversao1.calcular();

            Console.WriteLine("");

            Console.WriteLine("Resultado em Reais: {0}",conversao1.getReal().ToString("C"));
        }
    }
}
