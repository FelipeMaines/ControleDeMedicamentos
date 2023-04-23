using ControleDeMedicamentos.ConsoleAPP.Junta;
using ControleDeMedicamentos.ConsoleAPP.ModuloAquisicao;
using ControleDeMedicamentos.ConsoleAPP.ModuloFornecedor;
using ControleDeMedicamentos.ConsoleAPP.ModuloPaciente;
using ControleDeMedicamentos.ConsoleAPP.ModuloRemedio;
using ControleDeMedicamentos.ConsoleAPP.ModuloRequiscao;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleAPP.ModuloFuncionario
{
    public class TelaFuncionario : Tela
    {
        public Funcionario PegarInfoECriarFuncionario(ArrayList array)
        {
            int id = array.Count;

            Console.WriteLine("Qual o nome do funcionario? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o cpf do funcionario? ");
            string cpf = Console.ReadLine();

            Funcionario funcionario = new Funcionario(id, nome, cpf);

            return funcionario;
        }

        internal Funcionario PegarInformacoesDeEdicaoFuncionario(ArrayList array)
        {
            int id = array.Count;

            Console.WriteLine("Qual o nome do funcionario? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o cpf do funcionario? ");
            string cpf = Console.ReadLine();

            Funcionario funcionario = new Funcionario(id, nome, cpf);

            return funcionario;
        }
    }

    public class SubMenuFuncionario : FuncionarioRepositorio
    {
        int valor = 1;
        public void SubmenuFuncionario(ArrayList arrayFuncionarios, ArrayList Fornecedores, ArrayList Remedios, ArrayList Pacientes, ArrayList RemediosBaixoEstoque, ArrayList requisicaoes)
        {
            AquisicaoRepositorio aquisicaoRepositorio = new AquisicaoRepositorio();
            RequisicaoRepositorio requisicaoRepositorio = new RequisicaoRepositorio();
            TelaFuncionario telaFuncionario = new TelaFuncionario();
            Tela tela = new Tela();

            Console.WriteLine("[1] Cadastrar Funcionario");
            Console.WriteLine("[2] Editar Funcionario");
            Console.WriteLine("[3] Excluir Funcionario cadastrado");
            Console.WriteLine("[4] Ver Funcionario cadastrados");
            Console.WriteLine("[5] Fazer Requisicao");
            Console.WriteLine("[6] Fazer Aquisicao");

            valor = int.Parse(Console.ReadLine());

            switch (valor)
            {
                case 1:
                    Console.Clear();
                    CriarFuncionario(arrayFuncionarios);
                    tela.Mensagem("Funcionario cadastrado com sucesso", ConsoleColor.Green);
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 2:
                    Console.Clear();
                    telaFuncionario.MostrarObjetos<Funcionario>(arrayFuncionarios, camposFuncionarios);
                    int id = PerguntarId();
                    Funcionario funcionario = telaFuncionario.PegarInformacoesDeEdicaoFuncionario(arrayFuncionarios);
                    Editar(funcionario, id, arrayFuncionarios);
                    tela.Mensagem("Funcionario Editado com sucesso", ConsoleColor.Green);
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 3:
                    Console.Clear();
                    Excluir(arrayFuncionarios, camposFuncionarios);
                    tela.Mensagem("Funcionario Excluido com sucesso", ConsoleColor.Green);
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 4:
                    Console.Clear();
                    tela.MostrarObjetos<Funcionario>(arrayFuncionarios, camposFuncionarios);
                    Console.ReadLine();
                    Console.Clear();
                    break;


                case 5:
                    Console.Clear();
                    requisicaoRepositorio.FazerRequisicao(arrayFuncionarios, Pacientes, Remedios, Fornecedores, RemediosBaixoEstoque, requisicaoes);
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 6:
                    Console.Clear();
                    aquisicaoRepositorio.FazerAquisicao(Remedios, Fornecedores, arrayFuncionarios, RemediosBaixoEstoque);
                    Console.ReadLine();
                    Console.Clear();
                    break;

                    case 7: 
                    Console.Clear();
                    tela.MostrarObjetos<Requisicao>(requisicaoes, camposRequisicao);
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }

        }

    }
}
