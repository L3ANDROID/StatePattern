using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public abstract class Estado
    {
        public abstract void ControlarEstado(Contexto sw);
        public abstract string Describir();
    }
}
