using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de Cálculo de Área de Quadrilátero");
            Console.WriteLine();

            Console.Write("Valor da base: ");
            int valorBase = Convert.ToInt32(Console.ReadLine());
            Console.Write("Valor da altura: ");
            int valorAltura = Convert.ToInt32(Console.ReadLine());
            Quadrilatero quad = new Quadrilatero(valorBase, valorAltura);

            Console.WriteLine("------------------------------");
            quad.ExibirDados();
        }
    }
}
