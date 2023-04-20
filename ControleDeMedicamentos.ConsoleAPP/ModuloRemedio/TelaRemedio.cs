using ControleDeMedicamentos.ConsoleAPP.Junta;
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
    public class TelaRemedio : Tela
    {
        Repositorio repositorio = new Repositorio();

        public Remedio PegarInformacoesRemedio(ArrayList array)
        {
            int id = array.Count;

            Console.WriteLine("Qual o nome do Remedio? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a descricao do Remedio? ");
            string descricao = Console.ReadLine();

            Console.WriteLine("Qual a quantidade em estoque do Remedio? ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a qauntidade minima que deve ter no estoque?");
            int quantiadeMinima = int.Parse(Console.ReadLine());

            Remedio remedio = new Remedio(id, nome, descricao, quantidade, quantiadeMinima);

            return remedio;
        }

        public void MostrarRemedios(ArrayList array)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("|{0,-15} |{1,-15} |{2,-20} |{3,-20}", "Id", "Nome", "Descricao", "Quantidade em Estoque");

            foreach (Remedio item in array)
            {
                Console.WriteLine("|{0,-15} |{1,-15} |{2,-20} |{3,-20}", item.id, item.nome, item.descricao, item.quantidade);
            }

            Console.ResetColor();
        }

        public void EncherArrayBaixoEstoque(ArrayList arraybaixoestoque, ArrayList ListaRemedios)
        {
            foreach (Remedio item in ListaRemedios)
            {
                if(item.quantidade < 5)
                {
                    arraybaixoestoque.Add(item);
                }
            }
        }

        public void TirarDoBaixoEstoque(ArrayList arraybaixoestoque)
        {
            if(arraybaixoestoque == null)
            {
                return;
            }

            foreach (Remedio item in arraybaixoestoque)
            {
                if (item.quantidade >= 5)
                {
                    arraybaixoestoque.Remove(item);
                }
            }
        }

        public void MostrarRemediosBaixoEstoque(ArrayList arraybaixoestoque)
        {
            Console.Clear();

            if(arraybaixoestoque == null)
            {
                Mensagem("Nenhum remedio com baixo estoque", ConsoleColor.Green);
                Console.ReadLine();
                return;
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("|{0,-15} |{1,-15} |{2,-20} |{3,-20}", "Id", "Nome", "Descricao", "Quantidade em Estoque");

            foreach (Remedio item in arraybaixoestoque)
            {
                Console.WriteLine("|{0,-15} |{1,-15} |{2,-20} |{3,-20}", item.id, item.nome, item.descricao, item.quantidade);
            }

            finalMostrar();
        }

        public Remedio remedioMaisRetirado(ArrayList arrayRemedios)
        {
            int a = 0;
            Remedio remedio = null;

            foreach (Remedio item in arrayRemedios)
            {
                if(a < item.vezesRetirados )
                {
                    a = item.vezesRetirados;
                    remedio = item;
                }
            }
            return remedio;
        }

        public void MostrarRemedioMaisRetirado(ArrayList remediosCadastrados)
        {
            Remedio remedio = remedioMaisRetirado(remediosCadastrados);

            Console.WriteLine($"Remedio mais retirado:\n Nome: {remedio.nome}\n Id: {remedio.id} \n Descricao: {remedio.descricao}\n Quantidade de retiradas: {remedio.vezesRetirados}");
            finalMostrar();
        }

        private static void finalMostrar()
        {
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
        }
    }
}
