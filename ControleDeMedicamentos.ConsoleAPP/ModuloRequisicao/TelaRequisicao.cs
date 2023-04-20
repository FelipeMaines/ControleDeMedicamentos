using ControleDeMedicamentos.ConsoleAPP.Junta;
using ControleDeMedicamentos.ConsoleAPP.ModuloFuncionario;
using ControleDeMedicamentos.ConsoleAPP.ModuloPaciente;
using ControleDeMedicamentos.ConsoleAPP.ModuloRemedio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleAPP.Requisicao
{
    public class TelaRequisicao : Tela
    {
        TelaRemedio telaRemedio = new TelaRemedio();
        Repositorio repositorio = new Repositorio();
        TelaFuncionario telaFuncionario = new TelaFuncionario();
        public Paciente PegarPaciente(ArrayList pacientes)
        {
            //telaPaciente.MostrarPacientes(pacientes);

            MostrarObjetos<Paciente>(pacientes, repositorio.camposPacientes);
            int idPaciente = PegarOpcaoId("Qual o id do paciente");
            Paciente paciente = (Paciente)repositorio.BuscarPorId(pacientes, idPaciente);
            return paciente;
        }

        public Remedio PegarRemedio(ArrayList remediosCadastados)
        {
            //telaRemedio.MostrarRemedios(remediosCadastados);
            MostrarObjetos<Remedio>(remediosCadastados, repositorio.camposRemedio);
            int idRemedio = PegarOpcaoId("Qual o id do remedio?");
            Remedio remedio = (Remedio)repositorio.BuscarPorId(remediosCadastados, idRemedio);
            return remedio;
        }
            
        public int PegarQuantidadeRemedio()
        {
            Mensagem("Qual a quantidade de remedios?", ConsoleColor.White);
            int quantidadeRemedio = int.Parse(Console.ReadLine());
            return quantidadeRemedio;
        }

        public Funcionario PegarInformacoesFuncionario(ArrayList listaFuncionarios)
        {
            // telaFuncionario.MostrarFuncionarios(listaFuncionarios);
            MostrarObjetos<Funcionario>(listaFuncionarios, repositorio.camposFuncionarios);
            int idFunc = PegarOpcaoId("Qual o id do funcionario?");
            Funcionario funcionario = (Funcionario)repositorio.BuscarPorId(listaFuncionarios, idFunc);

            return funcionario;
        }

        
    }
}
