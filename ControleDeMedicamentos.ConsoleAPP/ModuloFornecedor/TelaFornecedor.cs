using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleAPP.ModuloFornecedor
{
    public class TelaFornecedor
    {
        public Fornecedor PegarInformacoesFornecedor()
        {
            ArrayList medicamentos = new ArrayList();
            string nomeMedicamento = "";

            Console.WriteLine("Qual o nome do fornecedor?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o CNPJ");
            string cnpj = Console.ReadLine();

            Console.WriteLine("Qual o numero de telefone?");
            string numeroTelefone = Console.ReadLine();

            do
            {
                Console.WriteLine("Qual os medicamentos que ele fornece?");
                nomeMedicamento = Console.ReadLine();

                if(nomeMedicamento != "s")
                medicamentos.Add(nomeMedicamento);

            } while (nomeMedicamento != "s");

            Fornecedor fornecedor = new Fornecedor(nome, cnpj, numeroTelefone, medicamentos);

            return fornecedor;
        }

        
    }
}
