using ControleDeMedicamentos.ConsoleAPP.Junta;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleAPP.ModuloRemedio
{
    public class RemedioRepositorio : Repositorio
    {
        public ArrayList remediosBaixoEstoque = new ArrayList();
        TelaRemedio tela = new TelaRemedio();

        public void CriarRemedio(ArrayList array)
        {
            Remedio remedio = tela.PegarECriarEntidade();
            AdicionarArray(array, remedio);
        }

       

       

    }


}
