using Practica_OCP.Interface;

namespace Practica_OCP.Class
{
    public class TaxCalculator
    {
        public decimal Calcular(decimal montoTotal, decimal deduccionTotal, string pais)
        {
            decimal montoImpuesto = 5000;
            decimal ingresoImponible = montoTotal - deduccionTotal;

            switch (pais)
            {
                case "USA":
                    montoImpuesto = new CalcularImpuestoUSA().CalcularImpuesto(montoTotal, deduccionTotal);
                    break;
                case "UK":
                    montoImpuesto = new CalcularImpuestoUK().CalcularImpuesto(montoTotal, deduccionTotal);
                    break;
                case "Republica Dominicana":
                    montoImpuesto = new CalcularImpuestoRD().CalcularImpuesto(montoTotal, deduccionTotal);
                    break;
                case "Canada":
                    montoImpuesto = new CalcularImpuestoCA().CalcularImpuesto(montoTotal, deduccionTotal);
                    break;
                default:
                    throw new NotSupportedException($"No se encontró una calculadora de impuestos para el país: {pais}");
            }
                
            return montoImpuesto;
        }
    }
       
}
