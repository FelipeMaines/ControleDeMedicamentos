using ControleDeMedicamentos.ConsoleAPP.Junta;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleAPP.ModuloRemedio
{
    public class Remedio : Entidade
    {
        public string nome { get; set; }
        public string descricao { get; set; }
        public int quantidade { get; set; }
        public ArrayList historicoRequisicao { get; set; }
        public int quantidadeMinima { get; set; }

        public Remedio()
        {
            
        }

        public Remedio(int id, string nome, string descricao, int quantidade)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.quantidade = quantidade;
            
        }
    }
}
