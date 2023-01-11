using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAjedrezPractica1
{
    public class Torre:PiezaAjedrez
    {
        public override string Mover()
        {
            return "Movimiento en línea recta o en horizontal";
        }
    }
}
