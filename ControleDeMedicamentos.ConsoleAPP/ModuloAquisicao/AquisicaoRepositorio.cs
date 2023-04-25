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
            if (VerificarSeExiste(remediosCadastados, Fornecedores, listaFuncionarios))
                return;

            Remedio remedio = (Remedio)PegarEntidade(remediosCadastados, "Qual remedio deseja adicionar?", camposRemedio);

            int idFornecedor = BuscarFornecedor(remedio, Fornecedores);

            if (VeriricarId(idFornecedor))
            {
                Console.Clear();
                return;
            }

            Fornecedor fornecedor = (Fornecedor)BuscarPorId(Fornecedores, idFornecedor);

            Console.Clear();

            Funcionario funcionario = (Funcionario)PegarEntidade(listaFuncionarios, "Qual o id do funcionario fazendo a Aquisicao?", camposFuncionarios);

            Console.Clear();

            DateTime date = DateTime.Today;
            int quantidade = tela.PegarOpcaoId("Qual a quantidade de medicamento deseja adicionar ao estoque?");
            remedio.quantidade += quantidade;

            Console.Clear();

            var aquisicao = new Aquisicao(fornecedor, remedio, funcionario, date, quantidade);
            AdicionarArray(listaRegistros, aquisicao);

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
                Console.Clear() ;
                return true;
            }
            return false;
        }

        private bool VerificarSeExiste(ArrayList remedios, ArrayList fornecedores, ArrayList funcionarios)
        {
            if(remedios.Count <= 0)
            {
                tela.Mensagem("Nenhum Remedio cadastrado! ", ConsoleColor.DarkRed);
                Console.ReadLine();
                Console.Clear();
                return true;
            }

            else if(fornecedores.Count <= 0)
            {

                tela.Mensagem("Nenhum Fornecedor cadastrado! ", ConsoleColor.DarkRed);
                Console.ReadLine();
                Console.Clear();
                return true;
            }

            else if (funcionarios.Count <= 0)
            {

                tela.Mensagem("Nenhum funcionario cadastrado! ", ConsoleColor.DarkRed);
                Console.ReadLine();
                Console.Clear();
                return true;
            }

            return false;
        }
    }
}
