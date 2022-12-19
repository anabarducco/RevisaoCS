using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    public class Pessoa
    {
		private int anoNascimento; // variável

		public int AnoNascimento // propriedade
		{
			get { return this.anoNascimento; }
			set { this.anoNascimento = value; }
		}

		private String nome; // variável

        public String Nome // propriedade
        {
			get { return this.nome; }
			set { this.nome = value.ToUpper(); }
		}

		// melhorando as propriedades da classe Pessoa
		private int idade;

		public int Idade
		{
			get 
			{ 
				this.CalcularIdade();
				return this.idade; 
			}
			// set { this.idade = value; } => não é necessário pois o usuário não irá entrar com esse dado
		}


		public void ExibirDados() // método para exibir dados no console
		{
			Console.WriteLine("Nome: " + this.Nome);
			Console.WriteLine("Ano de Nascimento: " + this.AnoNascimento);
			Console.WriteLine("Idade: " + this.Idade + " anos");
		}

		private void CalcularIdade() // método para calcular a idade a partir do ano de nascimento
		{
			DateTime data = DateTime.Now; // objeto data do tipo DateTime
			int anoAtual = data.Year;
			this.idade = anoAtual - this.AnoNascimento;
		}

	}
}
