using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_LSP.Class
{
    public class Cuadrado : FiguraGeometrica
    {
        public override double Base
        {
            get { return base.Base; }
            set { base.Base = base.Altura = value; }
        }
        public override double Altura
        {
            get { return base.Altura; }
            set { base.Altura = base.Base = value; }
        }
        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
