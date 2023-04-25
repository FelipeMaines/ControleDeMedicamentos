using ControleDeMedicamentos.ConsoleAPP.Junta;
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
    public class TelaPaciente : Tela
    {
        public override Paciente PegarECriarEntidade()
        {

            Console.WriteLine("Qual o nome do Paciente? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o cpf do Paciente? ");
            string cpf = Console.ReadLine();

            Console.WriteLine("Qual o numero do cartao do sus do Paciente? ");
            string sus = Console.ReadLine();

            Console.WriteLine("Qual o telefone do Paciente? ");
            string telefone = Console.ReadLine();

            Paciente paciente = new Paciente(nome, cpf, sus, telefone);

            return paciente;
        }
    }

    public class SubMenuPaciente : PacienteRepositorio
    {
        int valor = 1;
        public void SubmenuPaciente(ArrayList arrayPacientes)
        {
            Tela tela = new Tela();
            PacienteRepositorio paciente = new PacienteRepositorio();
            TelaPaciente telaPaceinte = new TelaPaciente();

            Console.WriteLine("[1] Cadastrar Paciente");
            Console.WriteLine("[2] Editar Paciente");
            Console.WriteLine("[3] Excluir Paciente cadastrado");
            Console.WriteLine("[4] Ver Pacientes cadastrados");
            valor = int.Parse(Console.ReadLine());

            switch (valor)
            {
                case 1:
                    Console.Clear();
                    paciente.CriarPaciente(arrayPacientes);
                    tela.Mensagem("Paciente cadastrado com sucesso", ConsoleColor.Green);
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 2:
                    EditarPaciente(arrayPacientes, tela, telaPaceinte);
                    break;

                case 4:
                    Console.Clear();
                    tela.MostrarObjetos<Paciente>(arrayPacientes, camposPacientes);
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 3:
                    Console.Clear();
                    Excluir(arrayPacientes, camposPacientes);
                    tela.Mensagem("Paciente Excluido com sucesso", ConsoleColor.Green);
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }

        private void EditarPaciente(ArrayList arrayPacientes, Tela tela, TelaPaciente telaPaceinte)
        {
            Console.Clear();
            tela.MostrarObjetos<Paciente>(arrayPacientes, camposPacientes);
            int id = PerguntarId();
            Console.Clear();
            Paciente pacienteEdicao = telaPaceinte.PegarECriarEntidade();
            Editar(pacienteEdicao, id, arrayPacientes);
            tela.Mensagem("Paciente Editado com sucesso", ConsoleColor.Green);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
