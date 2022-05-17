using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Contexto
    {
        Estado _estado;

        public Contexto()
        {
            _estado = new Activa();
        }

        public void DefinirEstado(Estado estado)
        {
            _estado = estado;
        }

        public void Presionar()
        {
            _estado.ControlarEstado(this);
            Console.WriteLine(_estado.Describir());
        }
    }

}
