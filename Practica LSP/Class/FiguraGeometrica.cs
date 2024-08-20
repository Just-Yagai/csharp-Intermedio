using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_LSP.Class
{
    public class FiguraGeometrica
    {
        public virtual double Base {  get; set; }
        public virtual double Altura { get; set; }
        public virtual double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
