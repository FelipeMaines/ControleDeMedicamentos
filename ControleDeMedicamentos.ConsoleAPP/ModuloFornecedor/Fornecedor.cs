using ControleDeMedicamentos.ConsoleAPP.Junta;
using ControleDeMedicamentos.ConsoleAPP.ModuloRemedio;
using System.Collections;
using System.Runtime.CompilerServices;

namespace ControleDeMedicamentos.ConsoleAPP.ModuloFornecedor
{
    public class Fornecedor : Entidade
    {
        public string nome { get; set; }
        public string numeroContato { get; set; }
        public ArrayList medicamentos { get; set; }
        public string cnpj { get; set; }

        public Fornecedor()
        {
            
        }

        public Fornecedor(int id, string nome, string cnpj, string numeroContato, ArrayList medicamentos)
        {
            this.nome = nome;
            this.numeroContato = numeroContato;
            this.cnpj = cnpj;
            this.medicamentos = medicamentos;
            this.id = id;
        }
    }
}
