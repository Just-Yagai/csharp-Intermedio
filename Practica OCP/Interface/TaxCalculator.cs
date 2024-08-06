namespace Practica_OCP.Interface
{
    public interface ICalculadoraImpuestos
    {
        decimal CalcularImpuesto(decimal montoTotal, decimal deduccionTotal);
    }
}
