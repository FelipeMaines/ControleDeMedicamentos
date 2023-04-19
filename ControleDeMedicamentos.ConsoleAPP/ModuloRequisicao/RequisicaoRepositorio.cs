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
        public Requisicao FazerRequisicao(ArrayList listaFuncionarios, ArrayList pacientes, ArrayList remediosCadastados, ArrayList fornecedores)
        {
            Console.Clear();
            Funcionario funcionario = NewMethod(listaFuncionarios);

            Console.Clear();

            Remedio remedio = telaRequisicao.PegarRemedio(remediosCadastados);
            VerificarSeAhRemedio(remedio, remediosCadastados, fornecedores, listaFuncionarios, pacientes);

            Console.Clear();

            Paciente paciente = telaRequisicao.PegarPaciente(pacientes);

            Console.Clear();

            int quantidadeRemedio = telaRequisicao.PegarQuantidadeRemedio();

            VerificarQuantidadeSaida(remedio, quantidadeRemedio);

            DateTime data = DateTime.Today;
            Requisicao requisicao = new Requisicao(paciente, remedio, funcionario, data, quantidadeRemedio);

            requisicoesAbertas.Add(requisicao);

            return requisicao;
        }

        private Funcionario NewMethod(ArrayList listaFuncionarios)
        {
            telaFunc.MostrarFuncionarios(listaFuncionarios);
            int idFunc = tela.PegarOpcaoId("Qual o id do funcionario?");
            Funcionario funcionario = (Funcionario)BuscarPorId(listaFuncionarios, idFunc);
            return funcionario;
        }

        private void VerificarSeAhRemedio(Remedio remedio, ArrayList remediosCadastados, ArrayList Fornecedores,ArrayList listaFuncionarios, ArrayList pacientes)
        {
            if(remedio.quantidade <= 0)
            {
                tela.Mensagem("Remedio sem estoque, fazendo requisicao ao fornecedor!", ConsoleColor.DarkYellow);
                aquisicao.FazerAquisicao(remediosCadastados, Fornecedores, listaFuncionarios);
            }
        }

        private void VerificarQuantidadeSaida(Remedio remedio, int quantidadeRemedio)
        {
            if (remedio.quantidade < quantidadeRemedio)
            {
                tela.Mensagem("Nao ah esse numero de remedio em estoque!", ConsoleColor.DarkRed);
                return;
            }
            else
                remedio.quantidade -= quantidadeRemedio;

            if (remedio.quantidadeMinima >= remedio.quantidade)
            {
                tela.Mensagem($"Recomendase fazer um pedido ao fornecedor para o remedio: {remedio.nome}", ConsoleColor.DarkYellow);
            }
        }
    }
}
