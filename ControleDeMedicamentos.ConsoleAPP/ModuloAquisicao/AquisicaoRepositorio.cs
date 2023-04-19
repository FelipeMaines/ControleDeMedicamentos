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
        TelaFuncionario telaFuncionario = new TelaFuncionario();
        TelaRemedio telaRemedio = new TelaRemedio();
        public void FazerAquisicao(ArrayList remediosCadastados, ArrayList Fornecedores, ArrayList listaFuncionarios)
        {
            telaRemedio.MostrarRemedios(remediosCadastados);
            int idMedicamento = tela.PegarInformacao("Qual o id do medicamento deseja adquirir? ");
            Remedio remedio = (Remedio)BuscarPorId(remediosCadastados, idMedicamento);

            int idFornecedor = BuscarFornecedor(remedio, Fornecedores);

            if(idFornecedor == 404)
            {
                tela.Mensagem("Nenhum Fornecedorr cadastrado forncesse esse medicamento!", ConsoleColor.DarkRed);
                Console.ReadLine();
                return;
            }

            Fornecedor fornecedor = (Fornecedor)BuscarPorId(Fornecedores, idFornecedor);
            
            Console.Clear();

            telaFuncionario.MostrarFuncionarios(listaFuncionarios);
            int idFuncionario = tela.PegarInformacao("Qual o id do funcionario fazendo a Aquisicao?");
            Funcionario funcionario = (Funcionario)BuscarPorId(listaFuncionarios, idFuncionario);
            DateTime date = DateTime.Today;

            int quantidade = tela.PegarInformacao("Qual a quantidade de medicamento deseja adicionar ao estoque?");

            remedio.quantidade += quantidade;

            var aquisicao = new Aquisicao(fornecedor, remedio, funcionario, date, quantidade);

            AdicionarArray(Aquisicao, aquisicao);
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
    }
}
