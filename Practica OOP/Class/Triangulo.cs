using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_OOP.Class
{
    public class Triangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Triangulo(double baseTriangle, double altura) 
        { 
            Base = baseTriangle;
            Altura = altura;
        }

        public override double CalArea()
        {
            return (Base * Altura) / 2;
        }
    }
}
