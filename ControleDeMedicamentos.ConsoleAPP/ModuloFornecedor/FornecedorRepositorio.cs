﻿using ControleDeMedicamentos.ConsoleAPP.Junta;
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
        public ArrayList Fornecedores = new ArrayList();
        TelaFornecedor tela = new TelaFornecedor();
        public void CriarFornecedor()
        {
            Fornecedor fornecedor = tela.PegarInformacoesFornecedor();

            AdicionarArray(Fornecedores, fornecedor);
        }
    }
}