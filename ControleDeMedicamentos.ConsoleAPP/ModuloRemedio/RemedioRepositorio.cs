﻿using ControleDeMedicamentos.ConsoleAPP.Junta;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleAPP.ModuloRemedio
{
    public class RemedioRepositorio : Repositorio
    {
        TelaRemedio tela = new TelaRemedio();

        public void CriarRemedio(ArrayList array)
        {

            Remedio remedio = tela.PegarInformacoesRemedio(array);
            AdicionarArray(array, remedio);
        }

       

       

    }


}
