using ControleDeMedicamentos.ConsoleAPP.Junta;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleAPP.ModuloFuncionario
{
    public class FuncionarioRepositorio : Repositorio
    {
        public TelaFuncionario telaFuncionario = new TelaFuncionario();
        public void CriarFuncionario(ArrayList listaFuncionarios)
        {
           Funcionario funcionario = telaFuncionario.PegarInfoECriarFuncionario(listaFuncionarios);

            AdicionarArray(listaFuncionarios, funcionario);
            Console.WriteLine("a");
        }
    }
}
