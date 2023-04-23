using ControleDeMedicamentos.ConsoleAPP.Junta;
using ControleDeMedicamentos.ConsoleAPP.ModuloRemedio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleAPP.ModuloPaciente
{
    public class Paciente : Entidade
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string cartaoSus { get; set; }
        public string telefone { get; set; }

        public Paciente()
        {
            
        }
        public Paciente(int id, string nome, string cpf, string sus, string telefone)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.cartaoSus = sus;
            this.telefone = telefone;
        }

        public override void Atualizar(Entidade entidadeAtualizada)
        {
            Paciente entidade = (Paciente)entidadeAtualizada;

            nome = entidade.nome;
            cpf = entidade.cpf;
            cartaoSus = entidade.cartaoSus;
            telefone = entidade.telefone;
        }
    }
}
