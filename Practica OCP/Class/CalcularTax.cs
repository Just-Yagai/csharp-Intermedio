using Practica_OCP.Interface;

namespace Practica_OCP.Class
{
    public class TaxCalculator
    {
        private readonly IDictionary<string, ICalculadoraImpuestos> _calculadorasPorPais;

        public TaxCalculator()
        {
            _calculadorasPorPais = new Dictionary<string, ICalculadoraImpuestos>
            {
                { "USA", new CalcularImpuestoUSA() },
                { "UK", new CalcularImpuestoUK() },
                { "Republica Dominicana", new CalcularImpuestoRD() },
                { "Canada", new CalcularImpuestoCA() }
            };
        }

        public decimal Calcular(decimal montoTotal, decimal deduccionTotal, string pais)
        {
            if (_calculadorasPorPais.TryGetValue(pais, out ICalculadoraImpuestos calculadora))
            {
                return calculadora.CalcularImpuesto(montoTotal, deduccionTotal);
            }
            else
            {
                throw new NotSupportedException($"No se encontró una calculadora de impuestos para el país: {pais}");
            }
        }
    }
       
}
