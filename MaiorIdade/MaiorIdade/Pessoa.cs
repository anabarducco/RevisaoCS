using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorIdade
{
    public class Pessoa
    {
		public Pessoa() { }
		public Pessoa(String nomePessoa, int idadePessoa) 
		{
			this.Nome = nomePessoa;
			this.Idade = idadePessoa;
		}

		private String nome;

		public String Nome
		{
			get { return nome; }
			set { nome = value.ToUpper(); }
		}

		private int idade;

		public int Idade
		{
			get { return idade; }
			set { idade = value; }
		}

		public void ExibirDados()
		{
			Console.WriteLine("Nome: " + this.Nome);
			Console.WriteLine("Idade: " + this.Idade);
		}
	}
}
