using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que Calcula a Idade de uma Pessoa");
            Pessoa p = new Pessoa(); 

            Console.Write("Insira o nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Insira o ano de nascimento: ");
            p.AnoNascimento = Convert.ToInt32(Console.ReadLine());

            p.ExibirDados();
        }
    }
}
