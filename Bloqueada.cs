using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Bloqueada : Estado
    {
        public override void ControlarEstado(Contexto sw)
        {
            sw.DefinirEstado(new Activa());
        }

        public override string Describir()
        {
            return "Cuenta bloqueada";
        }
    }

}
