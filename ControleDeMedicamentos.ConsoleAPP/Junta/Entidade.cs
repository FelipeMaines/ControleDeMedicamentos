using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleAPP.Junta
{
    public class Entidade
    {
        public int id { get; set; }
        public virtual void Atualizar(Entidade entidadeAtualizada)
        {
            id = entidadeAtualizada.id;
        }
    }

    

}
