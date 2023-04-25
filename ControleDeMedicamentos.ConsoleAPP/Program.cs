using ControleDeMedicamentos.ConsoleAPP.Junta;
using ControleDeMedicamentos.ConsoleAPP.ModuloAquisicao;
using ControleDeMedicamentos.ConsoleAPP.ModuloFornecedor;
using ControleDeMedicamentos.ConsoleAPP.ModuloFuncionario;
using ControleDeMedicamentos.ConsoleAPP.ModuloPaciente;
using ControleDeMedicamentos.ConsoleAPP.ModuloRemedio;
using ControleDeMedicamentos.ConsoleAPP.ModuloRequiscao;

namespace ControleDeMedicamentos.ConsoleAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 1;
            MostrarMenu(valor);
        }
        static void MostrarMenu(int valor)
        {
            Repositorio repositorio = new Repositorio();
            FuncionarioRepositorio func = new FuncionarioRepositorio();
            PacienteRepositorio paciente = new PacienteRepositorio();
            RemedioRepositorio repositorioRemedio = new RemedioRepositorio();
            FornecedorRepositorio fornecedor = new FornecedorRepositorio();
            SubMenuRemedio subMenuRemedio = new SubMenuRemedio();
            SubMenuPaciente subMenuPaciente = new SubMenuPaciente();
            SubMenuFuncionario subMenuFuncionario = new SubMenuFuncionario();
            SubMenuFornecedor subMenuFornecedor = new SubMenuFornecedor();
            Tela tela = new Tela();

            while (valor != 0)
            {
                Console.WriteLine("Qual Area deseja entrar?");
                Console.WriteLine("[1] Remedios");
                Console.WriteLine("[2] Pacientes");
                Console.WriteLine("[3] Funcionario");
                Console.WriteLine("[4] Fornecedores");
                Console.WriteLine("[0] Sair");
                valor = int.Parse(Console.ReadLine());

                switch (valor)
                {
                    case 1:
                        Console.Clear();
                        subMenuRemedio.SubmenuRemedio(repositorioRemedio.listaRegistros, repositorioRemedio.remediosBaixoEstoque);
                        break;

                    case 2:
                        Console.Clear();
                        subMenuPaciente.SubmenuPaciente(paciente.listaRegistros);
                        break;

                    case 3:
                        Console.Clear();
                        subMenuFuncionario.SubmenuFuncionario(func.listaRegistros, fornecedor.listaRegistros, repositorioRemedio.listaRegistros, paciente.listaRegistros, repositorioRemedio.remediosBaixoEstoque, repositorio.listaRegistros);
                        break;

                    case 4:
                        Console.Clear();
                        subMenuFornecedor.SubmenuFornecedor(fornecedor.listaRegistros, repositorioRemedio.listaRegistros);
                        break;
                }
            }
        }
    }
}