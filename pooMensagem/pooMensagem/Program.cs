using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1, msg2; // cria os objetos msg1, msg2 do tipo Mensagem

            //msg1 = new Mensagem(); // instancia o objeto msg1 como um novo objeto de Mensagem
            ////msg1.TextoMensagem = "Hello, World!";
            //msg1.setTextoMensagem("Hello, World!"); // seta seu atributo pelo método set
            ////msg1.ExibirMensagem();
            //Console.WriteLine(msg1.getTextoMensagem()); // mostra no console o valor de msg1

            //msg2 = new Mensagem(); // instancia o objeto msg2 como um novo objeto de Mensagem
            ////msg2.TextoMensagem = "Segundo Objeto";
            //msg2.setTextoMensagem("Segundo Objeto"); // seta seu atributo pelo método set
            ////msg2.ExibirMensagem();  
            //Console.WriteLine(msg2.getTextoMensagem()); // mostra no console o valor de msg2

            msg1 = new Mensagem();
            msg1.TextoMensagem = "Hello, World!";
            msg1.ExibirMensagem();

            Console.ReadKey();
        }
    }
}
