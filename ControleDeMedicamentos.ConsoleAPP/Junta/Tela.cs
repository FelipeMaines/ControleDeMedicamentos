using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleAPP.Junta
{
    public class Tela
    {
        public void Mensagem(string texto, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(texto);
            Console.ResetColor();
        }

        public int PegarOpcaoId(string mensagem)
        {
            Mensagem(mensagem, ConsoleColor.White);
            int id = int.Parse(Console.ReadLine());
            return id;
        }

        public int PegarInformacao(string mensagem)
        {
            Mensagem(mensagem, ConsoleColor.White);
            int item = int.Parse(Console.ReadLine());

            return item;
        }
    }
}
