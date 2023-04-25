using ControleDeMedicamentos.ConsoleAPP.Junta;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleAPP.ModuloFornecedor
{
    public class FornecedorRepositorio : Repositorio
    {
        TelaFornecedor tela = new TelaFornecedor();
        public void CriarFornecedor(ArrayList fornecedoresCadastrados)
        {
            Fornecedor fornecedor = tela.PegarECriarEntidade();

            AdicionarArray(fornecedoresCadastrados, fornecedor);
        }
    }
}
