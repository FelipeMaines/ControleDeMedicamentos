﻿using ControleDeMedicamentos.ConsoleAPP.Junta;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleAPP.ModuloPaciente
{
    public class PacienteRepositorio : Repositorio
    {
        TelaPaciente tela = new TelaPaciente();
        public void CriarPaciente(ArrayList pacientes)
        {
            Paciente paciente = tela.PegarECriarEntidade();
            AdicionarArray(pacientes, paciente);
        }
    }
}
