using ControleDeMedicamentos.ConsoleAPP.Junta;
using ControleDeMedicamentos.ConsoleAPP.ModuloFornecedor;
using ControleDeMedicamentos.ConsoleAPP.ModuloPaciente;
using ControleDeMedicamentos.ConsoleAPP.ModuloRemedio;
using ControleDeMedicamentos.ConsoleAPP.Requisicao;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleAPP.ModuloFuncionario
{
    public class TelaFuncionario : Tela
    {
    

        public Funcionario PegarInfoECriarFuncionario(ArrayList array)
        {
            int id = array.Count;

            Console.WriteLine("Qual o nome do funcionario? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o cpf do funcionario? ");
            string cpf = Console.ReadLine();

            Funcionario funcionario = new Funcionario(id, nome, cpf);

            return funcionario;
        }

        public void MostrarFuncionarios(ArrayList array)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("|{0,-15} |{1,-15} |{2,-20}", "Id", "Nome", "CPF");

            foreach (Funcionario item in array)
            {
                Console.WriteLine("|{0,-15} |{1,-15} |{2,-20}", item.id, item.nome, item.cpf);
            }


            Console.ResetColor();
        }

        
    }


}
