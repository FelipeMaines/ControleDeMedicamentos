using ControleDeMedicamentos.ConsoleAPP.Junta;
using ControleDeMedicamentos.ConsoleAPP.ModuloFornecedor;
using ControleDeMedicamentos.ConsoleAPP.ModuloFuncionario;
using ControleDeMedicamentos.ConsoleAPP.ModuloRemedio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleAPP.ModuloAquisicao
{
    internal class AquisicaoRepositorio : Repositorio
    {
        Tela tela = new Tela();
        AquisicaoTela telaAquisicao = new AquisicaoTela();
        TelaRemedio telaRemedio = new TelaRemedio();    
        public void FazerAquisicao(ArrayList remediosCadastados, ArrayList Fornecedores, ArrayList listaFuncionarios, ArrayList RemediosBaixoEstoque)
        {

            Remedio remedio = telaAquisicao.PegarValorRemedio(remediosCadastados);

            int idFornecedor = BuscarFornecedor(remedio, Fornecedores);

            if (VeriricarId(idFornecedor))
                return;

            Fornecedor fornecedor = (Fornecedor)BuscarPorId(Fornecedores, idFornecedor);

            Console.Clear();

            Funcionario funcionario = telaAquisicao.PegarValorFuncionario(listaFuncionarios);

            Console.Clear();

            DateTime date = DateTime.Today;
            int quantidade = tela.PegarInformacao("Qual a quantidade de medicamento deseja adicionar ao estoque?");
            remedio.quantidade += quantidade;

            Console.Clear();

            var aquisicao = new Aquisicao(fornecedor, remedio, funcionario, date, quantidade);
            AdicionarArray(Aquisicao, aquisicao);

            telaRemedio.TirarDoBaixoEstoque(RemediosBaixoEstoque);
            tela.Mensagem("Aquisicao feita com sucesso!", ConsoleColor.Green);
        }

        private int BuscarFornecedor(Remedio remedio, ArrayList Fornecedores)
        {
            int id = 0;

            foreach (Fornecedor item in Fornecedores)
            {
                if(item.medicamentos.Contains(remedio.nome))
                {
                    id = item.id;
                    return id;
                }
            }
            return 404;
        }

        private bool VeriricarId(int idFornecedor)
        {
            if (idFornecedor == 404)
            {
                tela.Mensagem("Nenhum Fornecedorr cadastrado forncesse esse medicamento!", ConsoleColor.DarkRed);
                Console.ReadLine();
                return true;
            }
            return false;
        }
    }
}
