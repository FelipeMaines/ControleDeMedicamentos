using ControleDeMedicamentos.ConsoleAPP.Junta;
using ControleDeMedicamentos.ConsoleAPP.ModuloAquisicao;
using ControleDeMedicamentos.ConsoleAPP.ModuloFornecedor;
using ControleDeMedicamentos.ConsoleAPP.ModuloFuncionario;
using ControleDeMedicamentos.ConsoleAPP.ModuloPaciente;
using ControleDeMedicamentos.ConsoleAPP.ModuloRemedio;
using ControleDeMedicamentos.ConsoleAPP.Requisicao;

namespace ControleDeMedicamentos.ConsoleAPP
{
    internal class Program
    {

        static Funcionario CriarFuncionarioAturomatico()
        {
            Funcionario func = new Funcionario();

            func.id = 1;
            func.cpf = "123123";
            func.nome = "Pedro";


            return func;
        }

        static Remedio CrirarRemedioAtomatico()
        {
            Remedio remedio = new Remedio();

            remedio.id = 1;
            remedio.descricao = "dor";
            remedio.nome = "dipirona";
            remedio.quantidadeMinima = 5;
            remedio.quantidade = 5;
            return remedio;
        }

        //static Fornecedor CirarForncedorAutomatico()
        //{
        //    Fornecedor fornecedor = new Fornecedor();

        //    fornecedor.id = 1;
        //    fornecedor.cnpj = "123123123";
        //    fornecedor.nome = "Jose";
        //    fornecedor.numeroContato = "12313213";


        //    return fornecedor;
        //}

        static Paciente CriarPacienteAutomatico()
        {
            var paciente = new Paciente();

            paciente.id = 1;
            paciente.cpf = "123213";
            paciente.cartaoSus = "12312321";
            paciente.nome = "Maria";
            paciente.telefone = "23123213";


            return paciente;
        }

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
            RequisicaoRepositorio requisicao = new RequisicaoRepositorio();
            RemedioRepositorio repositorioRemedio = new RemedioRepositorio();
            FornecedorRepositorio fornecedor = new FornecedorRepositorio();
            AquisicaoRepositorio aquisicao = new AquisicaoRepositorio();
            TelaRemedio telaRemedio = new TelaRemedio();
            Tela tela = new Tela();

            

            while (valor != 0)
            {
                Console.WriteLine("Qual Area deseja entrar?");
                Console.WriteLine("[1] Cadastrar Funcionario");
                Console.WriteLine("[2] Cadastrar Fornecedor");
                Console.WriteLine("[3] Cadastrar Remedios");
                Console.WriteLine("[4] Cadastrar Pacientes");
                Console.WriteLine("[5] Cadastrar Requisicoes");
                Console.WriteLine("[6] Fazer Aquisicao de medicamento");
                Console.WriteLine("[7] Ver remedios com baixo estoque");
                Console.WriteLine("[8] Ver remedios com maior frequencia de saida!");
                Console.WriteLine("[0] Sair");
                valor = int.Parse(Console.ReadLine());

                switch (valor)
                {
                    case 1:
                        Console.Clear();
                        Funcionario funcionario = CriarFuncionarioAturomatico();
                        repositorio.AdicionarArray(func.listaFuncionarios, funcionario);
                        break;

                    case 2:
                        Console.Clear();
                        //Fornecedor fornecedorAuto = CirarForncedorAutomatico();
                        //repositorio.AdicionarArray(fornecedor.Fornecedores, fornecedorAuto);
                        fornecedor.CriarFornecedor();
                        break;

                    case 3:
                        Console.Clear();
                        //Remedio remeioAuto = CrirarRemedioAtomatico();
                        //repositorio.AdicionarArray(repositorioRemedio.remediosCadastados, remeioAuto);
                        repositorioRemedio.CriarRemedio();
                        break;

                    case 4:
                        Console.Clear();
                        Paciente pacienteAuto = CriarPacienteAutomatico();
                        repositorio.AdicionarArray(paciente.pacientes, pacienteAuto);
                        break;

                    case 5:
                        Console.Clear();
                        requisicao.FazerRequisicao(func.listaFuncionarios, paciente.pacientes, repositorioRemedio.remediosCadastados, fornecedor.fornecedores, repositorio.RemediosBaixoEstoque);
                        break;

                    case 6:
                        Console.Clear();
                        aquisicao.FazerAquisicao(repositorioRemedio.remediosCadastados, fornecedor.fornecedores, func.listaFuncionarios, repositorio.RemediosBaixoEstoque);
                        break;

                    case 7:
                        Console.Clear();
                        tela.MostrarObjetos<Remedio>(repositorio.RemediosBaixoEstoque, repositorio.camposRemedio);
                        telaRemedio.MostrarRemediosBaixoEstoque(repositorio.RemediosBaixoEstoque);
                        break;

                    case 8:
                        Console.Clear();
                        telaRemedio.MostrarRemedioMaisRetirado(repositorioRemedio.remediosCadastados);
                        break;
                }
            }
        }
    }
}