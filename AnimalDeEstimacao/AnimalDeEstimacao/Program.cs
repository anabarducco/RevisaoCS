using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalDeEstimacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            Animal animal2 = new Animal();
            Animal animal3 = new Animal();
            Animal animal4 = new Animal();
            Animal animal5 = new Animal();

            int qtdCachorro = 0, qtdGato = 0, qtdPeixe = 0;

            Console.WriteLine("Cadastro de Animais de Estimação");

            Console.Write("Nome: ");
            animal1.Nome = Console.ReadLine();
            Console.WriteLine("Tipos:\nCachorro\nGato\nPeixe");
            Console.Write("Tipo: ");
            animal1.Tipo = Console.ReadLine();
            if(animal1.Tipo == "Cachorro")
            {
                qtdCachorro++;
            } else if(animal1.Tipo == "Gato") 
            {
                qtdGato++;
            } else { 
                qtdPeixe++;
            }

            Console.Write("Nome: ");
            animal2.Nome = Console.ReadLine();
            Console.WriteLine("Tipos:\nCachorro\nGato\nPeixe");
            Console.Write("Tipo: ");
            animal2.Tipo = Console.ReadLine();
            if (animal2.Tipo == "Cachorro")
            {
                qtdCachorro++;
            }
            else if (animal2.Tipo == "Gato")
            {
                qtdGato++;
            }
            else
            {
                qtdPeixe++;
            }

            Console.Write("Nome: ");
            animal3.Nome = Console.ReadLine();
            Console.WriteLine("Tipos:\nCachorro\nGato\nPeixe");
            Console.Write("Tipo: ");
            animal3.Tipo = Console.ReadLine();
            if (animal3.Tipo == "Cachorro")
            {
                qtdCachorro++;
            }
            else if (animal3.Tipo == "Gato")
            {
                qtdGato++;
            }
            else
            {
                qtdPeixe++;
            }

            Console.Write("Nome: ");
            animal4.Nome = Console.ReadLine();
            Console.WriteLine("Tipos:\nCachorro\nGato\nPeixe");
            Console.Write("Tipo: ");
            animal4.Tipo = Console.ReadLine();
            if (animal4.Tipo == "Cachorro")
            {
                qtdCachorro++;
            }
            else if (animal4.Tipo == "Gato")
            {
                qtdGato++;
            }
            else
            {
                qtdPeixe++;
            }

            Console.Write("Nome: ");
            animal5.Nome = Console.ReadLine();
            Console.WriteLine("Tipos:\nCachorro\nGato\nPeixe");
            Console.Write("Tipo: ");
            animal5.Tipo = Console.ReadLine();
            if (animal5.Tipo == "Cachorro")
            {
                qtdCachorro++;
            }
            else if (animal5.Tipo == "Gato")
            {
                qtdGato++;
            }
            else
            {
                qtdPeixe++;
            }

            Console.WriteLine("----------------------------------------");
            animal1.ExibirAnimal();
            animal2.ExibirAnimal();
            animal3.ExibirAnimal();
            animal4.ExibirAnimal();
            animal5.ExibirAnimal();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Ao todo, foram cadastrados " + qtdCachorro + " cachorros, " + 
                qtdGato + " gatos e " + qtdPeixe + " peixes.");
        }
    }
}
