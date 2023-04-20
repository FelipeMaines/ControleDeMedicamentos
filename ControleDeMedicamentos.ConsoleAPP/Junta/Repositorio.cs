using ControleDeMedicamentos.ConsoleAPP.ModuloFuncionario;
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
        public string[] camposRemedio = { "id","nome", "descricao", "quantidade", "quantidadeMinima" };
        public string[] camposFuncionarios = { "id", "nome", "cpf" };
        public string[] camposPacientes = { "id", "nome", "cpf", "cartaoSus", "telefone" };
       

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
    }
}
