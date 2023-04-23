using ControleDeMedicamentos.ConsoleAPP.Junta;
using ControleDeMedicamentos.ConsoleAPP.ModuloFuncionario;
using ControleDeMedicamentos.ConsoleAPP.ModuloPaciente;
using ControleDeMedicamentos.ConsoleAPP.ModuloRemedio;

namespace ControleDeMedicamentos.ConsoleAPP.ModuloRequiscao
{
    public class Requisicao : Entidade
    {
        public Paciente paciente;
        public Remedio remedio;
        public Funcionario funcionario;
        public DateTime data;
        public int quantidadeMedicamento;

        public Requisicao() { }

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
