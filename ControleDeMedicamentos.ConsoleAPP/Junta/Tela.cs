using System.Collections;

namespace ControleDeMedicamentos.ConsoleAPP.Junta
{
    public class Tela
    {
        public void Mensagem(string texto, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
        public int PegarOpcaoId(string mensagem)
        {
            Mensagem(mensagem, ConsoleColor.White);
            int id = int.Parse(Console.ReadLine());
            return id;
        }
        public void MostrarObjetos<T>(ArrayList array, string[] campos)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            foreach (string campo in campos)
            {
                Console.Write("|{0,-15}", campo);
            }

            Console.WriteLine();

            foreach (T item in array)
            {
                foreach (string campo in campos)
                {
                    object valor = item.GetType().GetProperty(campo).GetValue(item, null);

                    if (valor is int)  
                    {
                        valor = valor.ToString(); 
                    }

                    Console.Write("|{0,-15}", valor.ToString());
                }

                Console.WriteLine();
            }
            Console.ResetColor();
        }
        public virtual Entidade PegarECriarEntidade()
        {
            return null;
        }
    }
}
