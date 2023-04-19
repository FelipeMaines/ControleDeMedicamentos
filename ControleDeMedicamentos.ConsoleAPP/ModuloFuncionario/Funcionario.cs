using ControleDeMedicamentos.ConsoleAPP.Junta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleAPP.ModuloFuncionario
{
    public class Funcionario : Entidade
    {
        public string nome { get; set; }
        public string cpf { get; set; }

        public Funcionario()
        {
            
        }
        public Funcionario(int id, string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.id = id;
        }
    }
}
