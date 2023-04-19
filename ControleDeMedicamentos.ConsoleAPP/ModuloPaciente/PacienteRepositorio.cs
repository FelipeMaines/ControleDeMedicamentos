using ControleDeMedicamentos.ConsoleAPP.Junta;
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
        public void CriarPaciente()
        {
            Paciente paciente = tela.PegarInformacoesPaciente(pacientes);
            AdicionarArray(pacientes, paciente);
        }
    }
}
