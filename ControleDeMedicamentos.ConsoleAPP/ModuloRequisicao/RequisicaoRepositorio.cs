using ControleDeMedicamentos.ConsoleAPP.Junta;
using ControleDeMedicamentos.ConsoleAPP.ModuloAquisicao;
using ControleDeMedicamentos.ConsoleAPP.ModuloFuncionario;
using ControleDeMedicamentos.ConsoleAPP.ModuloPaciente;
using ControleDeMedicamentos.ConsoleAPP.ModuloRemedio;
using System;
using System.Collections;


namespace ControleDeMedicamentos.ConsoleAPP.Requisicao
{
    public class RequisicaoRepositorio : Repositorio
    {
        ArrayList requisicoesAbertas = new ArrayList();
        Tela tela = new Tela();
        TelaFuncionario telaFunc = new TelaFuncionario();
        TelaRemedio telaRemedio = new TelaRemedio();
        TelaPaciente telaPaciente = new TelaPaciente();
        TelaRequisicao telaRequisicao = new TelaRequisicao();
        AquisicaoRepositorio aquisicao = new AquisicaoRepositorio();
        public Requisicao FazerRequisicao(ArrayList listaFuncionarios, ArrayList pacientes, ArrayList remediosCadastados, ArrayList fornecedores, ArrayList RemediosBaixoEstoque)
        {
            Console.Clear();

            if (VerificarPacienteFuncionarioRemedio(listaFuncionarios, remediosCadastados, pacientes))
                return null;

            Funcionario funcionario = telaRequisicao.PegarInformacoesFuncionario(listaFuncionarios);

            Console.Clear();
            
            Remedio remedio = telaRequisicao.PegarRemedio(remediosCadastados);
            VerificarSeAhRemedio(remedio, remediosCadastados, fornecedores, listaFuncionarios, pacientes, RemediosBaixoEstoque);
            remedio.vezesRetirados += 1;

            Console.Clear();

            Paciente paciente = telaRequisicao.PegarPaciente(pacientes);

            Console.Clear();

            int quantidadeRemedio = telaRequisicao.PegarQuantidadeRemedio();

            VerificarQuantidadeSaida(remedio, quantidadeRemedio);

            DateTime data = DateTime.Today;
            Requisicao requisicao = new Requisicao(paciente, remedio, funcionario, data, quantidadeRemedio);

            requisicoesAbertas.Add(requisicao);

            telaRemedio.EncherArrayBaixoEstoque(RemediosBaixoEstoque, remediosCadastados);

            return requisicao;
        }

       private void VerificarSeAhRemedio(Remedio remedio, ArrayList remediosCadastados, ArrayList Fornecedores,ArrayList listaFuncionarios, ArrayList pacientes, ArrayList RemediosBaixoEstoque)
        {
            if(remedio.quantidade <= 0)
            {
                tela.Mensagem("Remedio sem estoque, fazendo requisicao ao fornecedor!", ConsoleColor.DarkYellow);
                Console.ReadLine();
                Console.Clear();
                aquisicao.FazerAquisicao(remediosCadastados, Fornecedores, listaFuncionarios, RemediosBaixoEstoque);
            }
        }

        private void VerificarQuantidadeSaida(Remedio remedio, int quantidadeRemedio)
        {
            if (remedio.quantidade < quantidadeRemedio)
            {
                tela.Mensagem("Nao ah esse numero de remedio em estoque!", ConsoleColor.DarkRed);
                Console.ReadLine();
                Console.Clear();
                return;
            }
            else
                remedio.quantidade -= quantidadeRemedio;

            if (remedio.quantidadeMinima >= remedio.quantidade)
            {
                tela.Mensagem($"Recomendase fazer um pedido ao fornecedor para o remedio: {remedio.nome}", ConsoleColor.DarkYellow);
                Console.ReadLine();
                Console.Clear();
                return;     
            }
        }

        private bool VerificarPacienteFuncionarioRemedio(ArrayList listaFuncionarios, ArrayList remediosCadastrados, ArrayList Pacientes)
        {
            if (listaFuncionarios.Count <= 0)
            {
                tela.Mensagem("Nenhum Funcionario cadastrado!", ConsoleColor.DarkRed);
                Console.ReadLine();
                Console.Clear();
                return true;
            }

            else if (remediosCadastrados.Count <= 0)
            {
                tela.Mensagem("Nenhum Remedio cadastrado!", ConsoleColor.DarkRed);
                Console.ReadLine();
                Console.Clear();
                return true;
            }

            else if (Pacientes.Count <= 0)
            {

                tela.Mensagem("Nenhum Paciente cadastrado!", ConsoleColor.DarkRed);
                Console.ReadLine();
                Console.Clear();
                return true;
            }

            return false;
        }
    }
}
