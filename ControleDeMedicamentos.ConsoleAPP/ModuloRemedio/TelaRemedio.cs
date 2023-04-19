using ControleDeMedicamentos.ConsoleAPP.ModuloFuncionario;
using ControleDeMedicamentos.ConsoleAPP.ModuloPaciente;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleAPP.ModuloRemedio
{
    public class TelaRemedio
    {
        public Remedio PegarInformacoesRemedio(ArrayList array)
        {
            int id = array.Count;

            Console.WriteLine("Qual o nome do Remedio? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a descricao do Remedio? ");
            string descricao = Console.ReadLine();

            Console.WriteLine("Qual a quantidade necessaria do Remedio? ");
            int quantidade = int.Parse(Console.ReadLine());

            Remedio remedio = new Remedio(id, nome, descricao, quantidade);

            return remedio;
        }

        public void MostrarRemedios(ArrayList array)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("|{0,-15} |{1,-15} |{2,-25} |{3,-25}", "Id", "Nome", "Descricao", "Quantidade em Estoque");

            foreach (Remedio item in array)
            {
                Console.WriteLine("|{0,-15} |{1,-15} |{2,-20} ||{3,-20}", item.id, item.nome, item.descricao, item.quantidade);
            }


            Console.ResetColor();
        }

    }
}
