using ControleDeMedicamentos.ConsoleAPP.ModuloFuncionario;
using ControleDeMedicamentos.ConsoleAPP.ModuloRemedio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleAPP.Junta
{

    public class Repositorio
    {
        public ArrayList listaFuncionarios = new ArrayList();
        public ArrayList pacientes = new ArrayList();
        public ArrayList remediosCadastados = new ArrayList();
        public ArrayList fornecedores = new ArrayList();
        public ArrayList Aquisicao = new ArrayList();
        public ArrayList RemediosBaixoEstoque = new ArrayList();
        public ArrayList requisicoesAbertas = new ArrayList();
        public string[] camposRemedio = { "id","nome", "descricao", "quantidade", "quantidadeMinima" };
        public string[] camposFuncionarios = { "id", "nome", "cpf" };
        public string[] camposPacientes = { "id", "nome", "cpf", "cartaoSus", "telefone" };
        public string[] camposFornecedor = { "id", "nome", "numeroContato", "cnpj" };
        public string[] camposRequisicao = { "id", "paciente", "remedio", "Funcionario", "Data", "quantidadeMedicamento" };

        

        Tela tela = new Tela();

        public void AdicionarArray(ArrayList array, Entidade item)
        {
            array.Add(item);
        }

        public Entidade BuscarPorId(ArrayList array, int id)
        {

            Entidade entidade = null;

            foreach (Entidade a in array)
            {
                if(a.id == id)
                {
                    entidade = a;
                }
            }

            return entidade;
        }

        public void Excluir(ArrayList array, string[] campo)
        {
            Entidade entidade = PegarEntidade(array, "Qual o id do remedio que deseja excluir", campo);

            int index = array.IndexOf(entidade);
            array.RemoveAt(index);
        }
        public Entidade PegarEntidade(ArrayList array, string mensagem, string[] campo)
        {
            Console.Clear();
            tela.MostrarObjetos<Entidade>(array, campo);

            tela.Mensagem(mensagem, ConsoleColor.White);
            int id = int.Parse(Console.ReadLine());
            Entidade entidade = BuscarPorId(array, id);
            return entidade;
        }

        public void Editar(Entidade entidadeAtualizada, int id, ArrayList array)
        {
            Entidade entidade = BuscarPorId(array, id);
            entidade.Atualizar(entidadeAtualizada);

            Console.ReadLine();
            Console.Clear();
        }

        public int PerguntarId()
        {
            Console.WriteLine("Qual o id deseja editar?");
            int id = int.Parse(Console.ReadLine());

            return id;
        }
    }
}
