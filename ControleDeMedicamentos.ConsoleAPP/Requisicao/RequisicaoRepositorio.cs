using ControleDeMedicamentos.ConsoleAPP.Junta;
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
        TelaFuncionario telaFUnc = new TelaFuncionario();
        TelaRemedio telaRemedio = new TelaRemedio();
        TelaPaciente telaPaciente = new TelaPaciente();
        public Requisicao FazerRequisicao(ArrayList listaFuncionarios, ArrayList pacientes, ArrayList remediosCadastados)
        {
            Console.Clear();

            telaFUnc.MostrarFuncionarios(listaFuncionarios);
            int idFunc = tela.PegarOpcaoId("Qual o id do funcionario?");
            Funcionario funcionario = (Funcionario)BuscarPorId(listaFuncionarios, idFunc);

            Console.Clear();

            telaRemedio.MostrarRemedios(remediosCadastados);
            int idRemedio = tela.PegarOpcaoId("Qual o id do remedio?");
            Remedio remedio = (Remedio)BuscarPorId(remediosCadastados, idRemedio);

            Console.Clear();

            telaPaciente.MostrarPacientes(pacientes);
            int idPaciente = tela.PegarOpcaoId("Qual o id do paciente");
            Paciente paciente = (Paciente)BuscarPorId(pacientes, idPaciente);

            Console.Clear();

            tela.Mensagem("Qual a quantidade de remedios?", ConsoleColor.White);
            int quantidadeRemedio = int.Parse(Console.ReadLine());

            DateTime data = DateTime.Today;
            Requisicao requisicao = new Requisicao(paciente, remedio, funcionario, data, quantidadeRemedio);

            requisicoesAbertas.Add(requisicao);

            return requisicao;
        }

       
    }
}
