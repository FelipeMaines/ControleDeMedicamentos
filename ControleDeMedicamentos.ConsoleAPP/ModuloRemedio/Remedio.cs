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
        Tela tela = new Tela();
        public string nome { get; set; }
        public string descricao { get; set; }
        public int quantidade { get; set; }

        public int vezesRetirados = 0;
        public int quantidadeMinima { get; set; }

        public Remedio()
        {
            
        }

        public Remedio(int id, string nome, string descricao, int quantidade, int quantidadeMinima)
        {
            
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.quantidade = quantidade;
            this.quantidadeMinima = quantidadeMinima;
        }

       public override void Atualizar(Entidade entidadeAtualizada)
        {
            Remedio entidade = (Remedio)entidadeAtualizada;

            nome = entidade.nome;
            descricao = entidade.descricao;
            quantidade = entidade.quantidade;
            quantidadeMinima = entidade.quantidadeMinima;
        }
    }
}
