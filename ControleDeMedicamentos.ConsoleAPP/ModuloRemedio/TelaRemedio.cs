using ControleDeMedicamentos.ConsoleAPP.Junta;
using ControleDeMedicamentos.ConsoleAPP.ModuloFornecedor;
using ControleDeMedicamentos.ConsoleAPP.ModuloPaciente;
using System;
using System.Collections;
using System.Drawing;


namespace ControleDeMedicamentos.ConsoleAPP.ModuloRemedio
{
    public class TelaRemedio : Tela
    {
        public override Remedio PegarECriarEntidade()
        {
            Console.WriteLine("Qual o nome do Remedio? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a descricao do Remedio? ");
            string descricao = Console.ReadLine();

            Console.WriteLine("Qual a quantidade em estoque do Remedio? ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a qauntidade minima que deve ter no estoque?");
            int quantiadeMinima = int.Parse(Console.ReadLine());

            Remedio remedio = new Remedio(nome, descricao, quantidade, quantiadeMinima);

            return remedio;
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
                return;

            else if (arraybaixoestoque.Count == 0)
                return;

            Remedio remedio = null;

            foreach (Remedio item in arraybaixoestoque)
            {
                if (item.quantidade >= 5)
                {
                    remedio = item;
                }
            }

            arraybaixoestoque.Remove(remedio);
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

    public class SubMenuRemedio : RemedioRepositorio
    {
        int valor = 1;
        public void SubmenuRemedio(ArrayList arrayRemedio, ArrayList baixoEstoque)
        {
            Repositorio repositorio = new Repositorio();
            TelaRemedio telaRemedio = new TelaRemedio();
            Tela tela = new Tela();

            Console.WriteLine("[1] Cadastrar remedio");
            Console.WriteLine("[2] Editar remedio");
            Console.WriteLine("[3] Excluir Remedio cadastrado");
            Console.WriteLine("[4] Ver Remedios cadastrados");
            Console.WriteLine("[5] Ver Remedios Com baixo estoque");
            Console.WriteLine("[6] Ver remedios com maior frequencia de saida!");

            valor = int.Parse(Console.ReadLine());

            switch (valor)
            {
                case 1:
                    Console.Clear();
                    CriarRemedio(arrayRemedio);
                    tela.Mensagem("Remedio cadastrado com sucesso", ConsoleColor.Green);
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 2:
                    Console.Clear();
                    tela.MostrarObjetos<Remedio>(arrayRemedio, camposRemedio);
                    int id = PerguntarId();
                    Remedio remedioatualizado = telaRemedio.PegarECriarEntidade();
                    Editar(remedioatualizado, id, arrayRemedio);
                    tela.Mensagem("Remedio Editado com sucesso", ConsoleColor.Green);
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 4:
                    Console.Clear();
                    tela.MostrarObjetos<Remedio>(arrayRemedio, camposRemedio);
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 3:
                    Console.Clear();
                    Excluir(arrayRemedio, camposRemedio);
                    tela.Mensagem("Remedio Editado com sucesso", ConsoleColor.Green);
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 5:
                    Console.Clear();
                    telaRemedio.MostrarRemediosBaixoEstoque(baixoEstoque);
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 6:
                    Console.Clear();
                    telaRemedio.MostrarRemedioMaisRetirado(arrayRemedio);
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
        
    }
}
