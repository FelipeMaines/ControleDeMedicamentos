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
        Tela tela = new Tela();
        public ArrayList listaRegistros = new ArrayList();
        public int contador = 0;
        public string[] camposRemedio = { "id","nome", "descricao", "quantidade", "quantidadeMinima" };
        public string[] camposFuncionarios = { "id", "nome", "cpf" };
        public string[] camposPacientes = { "id", "nome", "cpf", "cartaoSus", "telefone" };
        public string[] camposFornecedor = { "id", "nome", "numeroContato", "cnpj" };
        public string[] camposRequisicao = { "id", "paciente", "remedio", "Funcionario", "Data", "quantidadeMedicamento" };
        public void AdicionarArray(ArrayList array, Entidade item)
        {
            item.id = contador;
            contador++;
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
            Entidade entidade = PegarEntidade(array, "Qual o id da entidade que deseja excluir", campo);

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
