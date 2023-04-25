using ControleDeMedicamentos.ConsoleAPP.Junta;
using ControleDeMedicamentos.ConsoleAPP.ModuloFuncionario;
using ControleDeMedicamentos.ConsoleAPP.ModuloPaciente;
using ControleDeMedicamentos.ConsoleAPP.ModuloRemedio;
using System.Collections;

namespace ControleDeMedicamentos.ConsoleAPP.ModuloRequiscao
{
    public class TelaRequisicao : Tela
    {
        Repositorio repositorio = new Repositorio();
        public Paciente PegarPaciente(ArrayList pacientes)
        {
            MostrarObjetos<Paciente>(pacientes, repositorio.camposPacientes);
            int idPaciente = PegarOpcaoId("Qual o id do paciente");
            Paciente paciente = (Paciente)repositorio.BuscarPorId(pacientes, idPaciente);
            return paciente;
        }

        public Remedio PegarRemedio(ArrayList remediosCadastados)
        {
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
