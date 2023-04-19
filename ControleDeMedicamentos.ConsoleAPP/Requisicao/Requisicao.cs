using ControleDeMedicamentos.ConsoleAPP.ModuloFuncionario;
using ControleDeMedicamentos.ConsoleAPP.ModuloPaciente;
using ControleDeMedicamentos.ConsoleAPP.ModuloRemedio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleAPP.Requisicao
{
    public class Requisicao
    {
        public Paciente paciente;
        public Remedio remedio;
        public Funcionario funcionario;
        public DateTime data;
        public int quantidadeMedicamento;

        public Requisicao()
        {
            
        }

        public Requisicao(Paciente paciente, Remedio remedio, Funcionario funcionario, DateTime date, int quantidadeMedicamento)
        {
            this.paciente = paciente;
            this.remedio = remedio;
            this.funcionario = funcionario;
            this.data = date;
            this.quantidadeMedicamento = quantidadeMedicamento;
        }




    }
}
