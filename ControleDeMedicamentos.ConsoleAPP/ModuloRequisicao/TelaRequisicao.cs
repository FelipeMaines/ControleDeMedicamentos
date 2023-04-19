using ControleDeMedicamentos.ConsoleAPP.Junta;
using ControleDeMedicamentos.ConsoleAPP.ModuloPaciente;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleAPP.Requisicao
{
    public class TelaRequisicao : Tela
    {
        TelaPaciente telaPaciente = new TelaPaciente();
        Repositorio repositorio = new Repositorio();
        public Paciente PegarPaciente(ArrayList pacientes)
        {
            telaPaciente.MostrarPacientes(pacientes);
            int idPaciente = PegarOpcaoId("Qual o id do paciente");
            Paciente paciente = (Paciente)repositorio.BuscarPorId(pacientes, idPaciente);
            return paciente;
        }
    }
}
