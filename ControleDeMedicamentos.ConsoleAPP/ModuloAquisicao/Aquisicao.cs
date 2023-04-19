using ControleDeMedicamentos.ConsoleAPP.Junta;
using ControleDeMedicamentos.ConsoleAPP.ModuloFornecedor;
using ControleDeMedicamentos.ConsoleAPP.ModuloFuncionario;
using ControleDeMedicamentos.ConsoleAPP.ModuloRemedio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleAPP.ModuloAquisicao
{
    public class Aquisicao : Entidade
    {
        public Fornecedor fornecedor { get ; set; } 
        public Remedio remedio { get; set; }
        public Funcionario funcionario { get; set; }
        public DateTime data { get; set; }
        public int quantidadeMedicamento { get; set; }


        public Aquisicao()
        {
            
        }

        public Aquisicao(Fornecedor fornecedor, Remedio remedio, Funcionario funcionario, DateTime date, int quantidadeMedicamento)
        {
            
        }

    }
}
