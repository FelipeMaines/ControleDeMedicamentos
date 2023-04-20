using ControleDeMedicamentos.ConsoleAPP.Junta;
using ControleDeMedicamentos.ConsoleAPP.ModuloFuncionario;
using ControleDeMedicamentos.ConsoleAPP.ModuloRemedio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleAPP.ModuloAquisicao
{
    internal class AquisicaoTela : Tela
    {
        TelaRemedio telaRemedio = new TelaRemedio();
        Repositorio repositorio = new Repositorio();  
        TelaFuncionario Telafuncionario = new TelaFuncionario();
        public Remedio PegarValorRemedio(ArrayList remediosCadastrados)
        {
            telaRemedio.MostrarRemedios(remediosCadastrados);
            int idMedicamento = PegarInformacao("Qual o id do medicamento deseja adquirir? ");
            Remedio remedio = (Remedio)repositorio.BuscarPorId(remediosCadastrados, idMedicamento);

            return remedio;
        }

        public Funcionario PegarValorFuncionario(ArrayList listaFuncionarios)
        {
            Telafuncionario.MostrarFuncionarios(listaFuncionarios);
            int idFuncionario = PegarInformacao("Qual o id do funcionario fazendo a Aquisicao?");
            Funcionario funcionario = (Funcionario)repositorio.BuscarPorId(listaFuncionarios, idFuncionario);

            return funcionario;
        }


    }
}
    