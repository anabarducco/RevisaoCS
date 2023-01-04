using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de Pessoas");

            Console.WriteLine("----------------------------");
            Console.WriteLine("Pessoa 1"); 
            Console.Write("Nome: ");
            String nome = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Pessoa p1 = new Pessoa(nome, idade);

            Console.WriteLine("----------------------------");
            Console.WriteLine("Pessoa 2");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Pessoa p2 = new Pessoa(nome, idade);

            Console.WriteLine("----------------------------");
            Console.WriteLine("Pessoa 3");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Pessoa p3 = new Pessoa(nome, idade);

            Console.WriteLine("----------------------------");
            Console.WriteLine("As pessoas cadastradas foram: ");
            p1.ExibirDados();
            p2.ExibirDados();
            p3.ExibirDados();
            if ((p1.Idade > p2.Idade) && (p1.Idade > p3.Idade))
            {
                Console.WriteLine("A maior idade cadastrada foi da pessoa " + p1.Nome + " com " + p1.Idade + " anos.");
            } else if ((p2.Idade > p1.Idade) && (p2.Idade > p3.Idade))
            {
                Console.WriteLine("A maior idade cadastrada foi da pessoa " + p2.Nome + " com " + p2.Idade + " anos.");
            } else if ((p3.Idade > p1.Idade) && (p3.Idade > p2.Idade))
            {
                Console.WriteLine("A maior idade cadastrada foi da pessoa " + p3.Nome + " com " + p3.Idade + " anos.");
            } else
            {
                Console.WriteLine("Todas as pessoas cadastradas têm a mesma idade.");
            }
            
        }
    }
}
