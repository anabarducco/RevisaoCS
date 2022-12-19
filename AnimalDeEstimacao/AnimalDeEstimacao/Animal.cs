using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalDeEstimacao
{
    public class Animal
    {
		private String nome;

		public String Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		private String tipo;

		public String Tipo
		{
			get { return tipo; }
			set 
			{ 
				if(value == "Cachorro" || value == "Gato" || value == "Peixe") 
				{
					tipo = value;
				} else
				{
					tipo = "Peixe";
				}
			}
		}

		public void ExibirAnimal()
		{
			Console.WriteLine("Nome: " + this.Nome);
			Console.WriteLine("Tipo: " + this.Tipo);
		}

		
    }
}
