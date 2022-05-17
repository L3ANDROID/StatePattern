using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Activa : Estado
    {
        public override void ControlarEstado(Contexto sw)
        {
            sw.DefinirEstado(new Bloqueada());
        }

        public override string Describir()
        {
            return "Cuenta activa";
        }
    }
}
