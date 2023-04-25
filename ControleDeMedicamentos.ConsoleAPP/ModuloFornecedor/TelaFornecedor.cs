using ControleDeMedicamentos.ConsoleAPP.Junta;
using ControleDeMedicamentos.ConsoleAPP.ModuloRemedio;
using System.Collections;


namespace ControleDeMedicamentos.ConsoleAPP.ModuloFornecedor
{
    public class TelaFornecedor : Tela
    {
        public override Fornecedor PegarECriarEntidade()
        {
            ArrayList medicamentos = new ArrayList();
            string nomeMedicamento = "";

            Console.WriteLine("Qual o nome do fornecedor?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o CNPJ");
            string cnpj = Console.ReadLine();

            Console.WriteLine("Qual o numero de telefone?");
            string numeroTelefone = Console.ReadLine();
    
            do
            {
                Console.WriteLine("Qual os medicamentos que ele fornece? / s para sair");
                nomeMedicamento = Console.ReadLine();

                if(nomeMedicamento != "s")
                medicamentos.Add(nomeMedicamento);

            } while (nomeMedicamento != "s");

            Fornecedor fornecedor = new Fornecedor(nome, cnpj, numeroTelefone, medicamentos);

            Mensagem("Forncedor cadastrado com sucesso!", ConsoleColor.Green);
            Console.ReadLine();
            Console.Clear();
            return fornecedor;
        }
    }

    public class SubMenuFornecedor : FornecedorRepositorio
    {
        int valor = 1;
        public void SubmenuFornecedor(ArrayList fornecedoresCadastrados, ArrayList remediosCadastrados)
        {
            Tela tela = new Tela();
            FornecedorRepositorio fornecedorRepositorio = new FornecedorRepositorio();
            TelaFornecedor telaFornecedor = new TelaFornecedor();

            Console.WriteLine("[1] Cadastrar Forncedor");
            Console.WriteLine("[2] Editar Forncedor");
            Console.WriteLine("[3] Excluir Forncedor cadastrado");
            Console.WriteLine("[4] Ver Forncedor cadastrados");

            valor = int.Parse(Console.ReadLine());

            switch (valor)
            {
                case 1:
                    Console.Clear();
                    fornecedorRepositorio.CriarFornecedor(fornecedoresCadastrados);
                    tela.Mensagem("Remedio cadastrado com sucesso", ConsoleColor.Green);
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 2:
                    Console.Clear();
                    int id = PerguntarId();
                    Fornecedor fornecedor = telaFornecedor.PegarECriarEntidade();
                    Editar(fornecedor, id, fornecedoresCadastrados);
                    tela.Mensagem("Fornecedor Editado com sucesso", ConsoleColor.Green);
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 4:
                    Console.Clear();
                    tela.MostrarObjetos<Fornecedor>(fornecedoresCadastrados, camposFornecedor);
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 3:
                    Console.Clear();
                    Excluir(fornecedoresCadastrados, camposFornecedor);
                    tela.Mensagem("Remedio Editado com sucesso", ConsoleColor.Green);
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
    }
}

