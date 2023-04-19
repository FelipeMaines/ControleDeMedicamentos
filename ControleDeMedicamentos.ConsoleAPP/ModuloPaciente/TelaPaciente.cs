using ControleDeMedicamentos.ConsoleAPP.ModuloFuncionario;
using ControleDeMedicamentos.ConsoleAPP.ModuloRemedio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleAPP.ModuloPaciente
{
    public class TelaPaciente
    {
        public Paciente PegarInformacoesPaciente(ArrayList array)
        {
            int id = array.Count;

            Console.WriteLine("Qual o nome do Paciente? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o cpf do Paciente? ");
            string cpf = Console.ReadLine();

            Console.WriteLine("Qual o numero do cartao do sus do Paciente? ");
            string sus = Console.ReadLine();

            Console.WriteLine("Qual o telefone do Paciente? ");
            string telefone = Console.ReadLine();

            Paciente paciente = new Paciente(id, nome, cpf, sus , telefone);

            return paciente;
        }

        public void MostrarPacientes(ArrayList array)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("|{0,-15} |{1,-15} |{2,-20} |{3,-20}", "Id", "Nome", "Cartao do Sus", "cpf");

            foreach (Paciente item in array)
            {
                Console.WriteLine("|{0,-15} |{1,-15} |{2,-20} ||{3,-20}", item.id, item.nome, item.cartaoSus, item.cpf);
            }

            Console.ResetColor();
        }
    }
}
