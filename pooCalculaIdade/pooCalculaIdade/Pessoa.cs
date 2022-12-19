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

		public void ExibirDados() // método para exibir dados no console
		{
			Console.WriteLine("Nome: " + this.Nome);
			Console.WriteLine("Ano de Nascimento: " + this.AnoNascimento);
			Console.WriteLine("Idade: " + this.CalcularIdade() + " anos");
		}

		private int CalcularIdade() // método para calcular a idade a partir do ano de nascimento
		{
			DateTime data = DateTime.Now; // objeto data do tipo DateTime
			int anoAtual = data.Year;
			int idade = anoAtual - this.AnoNascimento;

			return idade;
		}

	}
}
