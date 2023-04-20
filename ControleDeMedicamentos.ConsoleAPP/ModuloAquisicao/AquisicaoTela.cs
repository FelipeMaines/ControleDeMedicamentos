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
        Repositorio repositorio = new Repositorio();  
        public Remedio PegarValorRemedio(ArrayList remediosCadastrados)
        {
            //telaRemedio.MostrarRemedios(remediosCadastrados);
            MostrarObjetos<Remedio>(remediosCadastrados, repositorio.camposRemedio);
            int idMedicamento = PegarInformacao("Qual o id do medicamento deseja adquirir? ");
            Remedio remedio = (Remedio)repositorio.BuscarPorId(remediosCadastrados, idMedicamento);

            return remedio;
        }

        public Funcionario PegarValorFuncionario(ArrayList listaFuncionarios)
        {
            //Telafuncionario.MostrarFuncionarios(listaFuncionarios);
            MostrarObjetos<Funcionario>(listaFuncionarios, repositorio.camposFuncionarios);

            int idFuncionario = PegarInformacao("Qual o id do funcionario fazendo a Aquisicao?");
            Funcionario funcionario = (Funcionario)repositorio.BuscarPorId(listaFuncionarios, idFuncionario);

            return funcionario;
        }


    }
}
    