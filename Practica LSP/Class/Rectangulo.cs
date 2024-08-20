using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_LSP.Class
{
    public class Rectangulo : FiguraGeometrica
    {
        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
