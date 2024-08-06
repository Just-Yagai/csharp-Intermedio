﻿using Practica_OCP.Interface;

namespace Practica_OCP.Class
{
    public class CalcularImpuestoRD : ICalculadoraImpuestos
    {
        public decimal CalcularImpuesto(decimal montoTotal, decimal deduccionTotal)
        {
            decimal ingresoImponible = montoTotal - deduccionTotal;
            decimal montoImpuesto = ingresoImponible * 0.15m;

            return montoImpuesto;
        }
    }
}