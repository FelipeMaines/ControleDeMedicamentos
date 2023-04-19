using ControleDeMedicamentos.ConsoleAPP.ModuloFuncionario;
using ControleDeMedicamentos.ConsoleAPP.ModuloPaciente;
using ControleDeMedicamentos.ConsoleAPP.ModuloRemedio;
using ControleDeMedicamentos.ConsoleAPP.Requisicao;

namespace ControleDeMedicamentos.ConsoleAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FuncionarioRepositorio func = new FuncionarioRepositorio();
            PacienteRepositorio paciente = new PacienteRepositorio();
            RequisicaoRepositorio requisicao = new RequisicaoRepositorio();
            RemedioRepositorio remedio = new RemedioRepositorio();
            int valor = 1;

            while (valor != 0) 
            {

                Console.WriteLine("Qual Area deseja entrar?");
                Console.WriteLine("[1] Funcionario");
                Console.WriteLine("[2] Fornecedor");
                Console.WriteLine("[3] Remedios");
                Console.WriteLine("[4] Pacientes");
                Console.WriteLine("[5] Requisicoes");



                switch (valor)
                {

                }
            }
            func.CriarFuncionario();
            paciente.CriarPaciente();
            remedio.CriarRemedio();

            func.listaFuncionarios.Sort();

            requisicao.FazerRequisicao(func.listaFuncionarios, paciente.pacientes, remedio.remediosCadastados);

            Console.WriteLine(requisicao);
        }
    }
}